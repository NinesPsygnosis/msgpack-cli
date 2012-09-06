﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
#if SILVERLIGHT
using System.Collections.Generic;
#else
using System.Collections.Concurrent;
#endif
using System.Diagnostics.Contracts;
#if NETFX_CORE
using System.Linq.Expressions;
#endif
#if !NETFX_CORE
using MsgPack.Serialization.EmittingSerializers;
#endif
#if !WINDOWS_PHONE
using MsgPack.Serialization.ExpressionSerializers;
#endif

namespace MsgPack.Serialization
{
	/// <summary>
	///		Defines entry points for <see cref="MessagePackSerializer{T}"/> usage.
	/// </summary>
	public static class MessagePackSerializer
	{
		/// <summary>
		///		Creates new <see cref="MessagePackSerializer{T}"/> instance with <see cref="SerializationContext.Default"/>.
		/// </summary>
		/// <typeparam name="T">Target type.</typeparam>
		/// <returns>
		///		New <see cref="MessagePackSerializer{T}"/> instance to serialize/deserialize the object tree which the top is <typeparamref name="T"/>.
		/// </returns>
		public static MessagePackSerializer<T> Create<T>()
		{
			Contract.Ensures( Contract.Result<MessagePackSerializer<T>>() != null );

			return MessagePackSerializer.Create<T>( SerializationContext.Default );
		}

		/// <summary>
		///		Creates new <see cref="MessagePackSerializer{T}"/> instance with specified <see cref="SerializationContext"/>.
		/// </summary>
		/// <typeparam name="T">Target type.</typeparam>
		/// <param name="context">
		///		<see cref="SerializationContext"/> to store known/created serializers.
		/// </param>
		/// <returns>
		///		New <see cref="MessagePackSerializer{T}"/> instance to serialize/deserialize the object tree which the top is <typeparamref name="T"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="context"/> is <c>null</c>.
		/// </exception>
		public static MessagePackSerializer<T> Create<T>( SerializationContext context )
		{
			if ( context == null )
			{
				throw new ArgumentNullException( "context" );
			}

			Contract.Ensures( Contract.Result<MessagePackSerializer<T>>() != null );

			Func<SerializationContext, SerializerBuilder<T>> builderProvider;
#if NETFX_CORE
			builderProvider = c => new ExpressionSerializerBuilder<T>( c );
#else
#if !WINDOWS_PHONE
			if ( context.EmitterFlavor == EmitterFlavor.ExpressionBased )
			{
				builderProvider = c => new ExpressionSerializerBuilder<T>( c );
			}
			else
			{
#endif // !WINDOWS_PHONE
				if ( context.SerializationMethod == SerializationMethod.Map )
				{
					builderProvider = c => new MapEmittingSerializerBuilder<T>( c );
				}
				else
				{
					builderProvider = c => new ArrayEmittingSerializerBuilder<T>( c );
				}
#if !WINDOWS_PHONE
			}
#endif // !WINDOWS_PHONE
#endif // NETFX_CORE else

			return new AutoMessagePackSerializer<T>( context, builderProvider );
		}

#if !SILVERLIGHT
		private static readonly ConcurrentDictionary<Type, Func<SerializationContext, IMessagePackSerializer>> _creatorCache = new ConcurrentDictionary<Type, Func<SerializationContext, IMessagePackSerializer>>();
#else
		private static readonly object _syncRoot = new object();
		private static readonly Dictionary<Type, Func<SerializationContext, IMessagePackSerializer>> _creatorCache = new Dictionary<Type, Func<SerializationContext, IMessagePackSerializer>>();
#endif

		/// <summary>
		///		Creates new <see cref="IMessagePackSerializer"/> instance with <see cref="SerializationContext.Default"/>.
		/// </summary>
		/// <param name="targetType">Target type.</param>
		/// <returns>
		///		New <see cref="IMessagePackSerializer"/> instance to serialize/deserialize the object tree which the top is <paramref name="targetType"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="targetType"/> is <c>null</c>.
		/// </exception>
		/// <remarks>
		///		To avoid boxing and strongly typed API is prefered, use <see cref="Create{T}()"/> instead when possible.
		/// </remarks>
		public static IMessagePackSerializer Create( Type targetType )
		{
			return MessagePackSerializer.Create( targetType, SerializationContext.Default );
		}

		/// <summary>
		///		Creates new <see cref="IMessagePackSerializer"/> instance with specified <see cref="SerializationContext"/>.
		/// </summary>
		/// <param name="targetType">Target type.</param>
		/// <param name="context">
		///		<see cref="SerializationContext"/> to store known/created serializers.
		/// </param>
		/// <returns>
		///		New <see cref="IMessagePackSerializer"/> instance to serialize/deserialize the object tree which the top is <paramref name="targetType"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="targetType"/> is <c>null</c>.
		///		Or, <paramref name="context"/> is <c>null</c>.
		/// </exception>
		/// <remarks>
		///		To avoid boxing and strongly typed API is prefered, use <see cref="Create{T}(SerializationContext)"/> instead when possible.
		/// </remarks>
		public static IMessagePackSerializer Create( Type targetType, SerializationContext context )
		{
			if ( targetType == null )
			{
				throw new ArgumentNullException( "targetType" );
			}

			if ( context == null )
			{
				throw new ArgumentNullException( "context" );
			}

			Contract.Ensures( Contract.Result<IMessagePackSerializer>() != null );

#if NETFX_CORE
			var factory =
				_creatorCache.GetOrAdd(
					targetType,
					type =>
					{
						var contextParameter = Expression.Parameter( typeof( SerializationContext ), "context" );
						// Utilize covariance of delegate.
						return
							Expression.Lambda<Func<SerializationContext, IMessagePackSerializer>>(
								Expression.Call(
									contextParameter,
									Metadata._MessagePackSerializer.Create1_Method.MakeGenericMethod( type )
								),
								contextParameter
							).Compile();
					}
				);
#elif SILVERLIGHT
			Func<SerializationContext, IMessagePackSerializer> factory;

			lock ( _syncRoot )
			{
				_creatorCache.TryGetValue( targetType, out factory );
			}

			if ( factory == null )
			{
				// Utilize covariance of delegate.
				factory =
					Delegate.CreateDelegate(
						typeof( Func<SerializationContext, IMessagePackSerializer> ),
						Metadata._MessagePackSerializer.Create1_Method.MakeGenericMethod( targetType )
						) as Func<SerializationContext, IMessagePackSerializer>;

				lock ( _syncRoot )
				{
					_creatorCache[ targetType ] = factory;
				}
			}
#else
			var factory =
				_creatorCache.GetOrAdd(
					targetType,
					type =>
						// Utilize covariance of delegate.
						Delegate.CreateDelegate(
							typeof( Func<SerializationContext, IMessagePackSerializer> ),
							Metadata._MessagePackSerializer.Create1_Method.MakeGenericMethod( type )
						) as Func<SerializationContext, IMessagePackSerializer>
				);
#endif
			return factory( context );
		}

		/// <summary>
		///		Gets a <see cref="MessagePackSerializer{T}"/> instance stored in <see cref="SerializationContext.Default"/>.
		///		If a serializer for <typeparamref name="T"/> is not stored, <see cref="Create{T}()"/> will be called automatically.
		/// </summary>
		/// <typeparam name="T">Target type.</typeparam>
		/// <returns>
		///		New <see cref="MessagePackSerializer{T}"/> instance to serialize/deserialize the object tree which the top is <typeparamref name="T"/>.
		/// </returns>
		public static MessagePackSerializer<T> Get<T>()
		{
			Contract.Ensures( Contract.Result<MessagePackSerializer<T>>() != null );

			return Get<T>( SerializationContext.Default );
		}

		/// <summary>
		///		Gets a <see cref="MessagePackSerializer{T}"/> instance stored in the specified <see cref="SerializationContext"/>.
		///		If a serializer for <typeparamref name="T"/> is not stored, <see cref="Create{T}(SerializationContext)"/> will be called automatically.
		/// </summary>
		/// <typeparam name="T">Target type.</typeparam>
		/// <param name="context">
		///		<see cref="SerializationContext"/> to store known/created serializers.
		/// </param>
		/// <returns>
		///		New <see cref="MessagePackSerializer{T}"/> instance to serialize/deserialize the object tree which the top is <typeparamref name="T"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="context"/> is <c>null</c>.
		/// </exception>
		public static MessagePackSerializer<T> Get<T>( SerializationContext context )
		{
			if ( context == null )
			{
				throw new ArgumentNullException( "context" );
			}

			Contract.Ensures( Contract.Result<MessagePackSerializer<T>>() != null );

			return context.GetSerializer<T>();
		}

		/// <summary>
		///		Gets a <see cref="IMessagePackSerializer"/> instance stored in <see cref="SerializationContext.Default"/>.
		///		If a serializer for <paramref name="targetType"/> is not stored, <see cref="Create(Type)"/> will be called automatically.
		/// </summary>
		/// <param name="targetType">Target type.</param>
		/// <returns>
		///		A new <see cref="IMessagePackSerializer"/> instance to serialize/deserialize the object tree which the top is <paramref name="targetType"/> type.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="targetType"/> is <c>null</c>.
		/// </exception>
		/// <remarks>
		///		To avoid boxing and strongly typed API is prefered, use <see cref="Get{T}()"/> instead when possible.
		/// </remarks>
		public static IMessagePackSerializer Get( Type targetType )
		{
			Contract.Ensures( Contract.Result<IMessagePackSerializer>() != null );

			return Get( targetType, SerializationContext.Default );
		}

		/// <summary>
		///		Gets a <see cref="IMessagePackSerializer"/> instance stored in the specified <see cref="SerializationContext"/>.
		///		If a serializer for <paramref name="targetType"/> is not stored, <see cref="Create(Type,SerializationContext)"/> will be called automatically.
		/// </summary>
		/// <param name="targetType">Target type.</param>
		/// <param name="context">
		///		<see cref="SerializationContext"/> to store known/created serializers.
		/// </param>
		/// <returns>
		///		A new <see cref="IMessagePackSerializer"/> instance to serialize/deserialize the object tree which the top is <paramref name="targetType"/> type.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		///		<paramref name="targetType"/> is <c>null</c>.
		///		Or, <paramref name="context"/> is <c>null</c>.
		/// </exception>
		/// <remarks>
		///		To avoid boxing and strongly typed API is prefered, use <see cref="Get{T}(SerializationContext)"/> instead when possible.
		/// </remarks>
		public static IMessagePackSerializer Get( Type targetType, SerializationContext context )
		{
			if ( targetType == null )
			{
				throw new ArgumentNullException( "targetType" );
			}

			if ( context == null )
			{
				throw new ArgumentNullException( "context" );
			}

			Contract.Ensures( Contract.Result<IMessagePackSerializer>() != null );

			return context.GetSerializer( targetType );
		}
	}
}
