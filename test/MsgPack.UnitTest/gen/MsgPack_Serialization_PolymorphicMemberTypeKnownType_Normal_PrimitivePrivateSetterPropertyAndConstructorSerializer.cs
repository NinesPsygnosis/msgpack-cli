﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Reflection.MethodBase _methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int> this_SetUnpackedValueOfPrimitiveDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, int> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>> _unpackOperationTable;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>> MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
            this._methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0 = MsgPack.Serialization.ReflectionHelpers.GetMethod(typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor), "set_Primitive", new System.Type[] {
                        typeof(int)});
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(this.PackValueOfPrimitive);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPrimitiveAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>>(1);
            packOperationTable["Primitive"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(this.PackValueOfPrimitive);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Primitive"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfPrimitiveAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, bool>>(0);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfPrimitive);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPrimitiveAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>>(1);
            unpackOperationTable["Primitive"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int>(this.UnpackValueOfPrimitive);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Primitive"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfPrimitiveAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Primitive"};
            this.this_SetUnpackedValueOfPrimitiveDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int>(this.SetUnpackedValueOfPrimitive);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, int>(MsgPack.Serialization.UnpackHelpers.UnpackInt32Value);
            this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, System.Threading.CancellationToken, System.Threading.Tasks.Task<int>>(MsgPack.Serialization.UnpackHelpers.UnpackInt32ValueAsync);
        }
        
        private void PackValueOfPrimitive(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Primitive);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private System.Threading.Tasks.Task PackValueOfPrimitiveAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Primitive, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTableAsync;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            packHelperParameters0.CancellationToken = cancellationToken;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                return MsgPack.Serialization.PackHelpers.PackToArrayAsync(ref packHelperParameters);
            }
            else {
                return MsgPack.Serialization.PackHelpers.PackToMapAsync(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfPrimitive(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor unpackingContext, int unpackedValue) {
            this._methodBasePolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor_set_Primitive0.Invoke(unpackingContext, new object[] {
                        ((object)(unpackedValue))});
        }
        
        private void UnpackValueOfPrimitive(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int> unpackHelperParameters = default(MsgPack.Serialization.UnpackValueTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(int);
            unpackHelperParameters.MemberName = "Primitive";
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfPrimitiveDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfPrimitiveAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int> unpackHelperParameters = default(MsgPack.Serialization.UnpackValueTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor, int>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(int);
            unpackHelperParameters.MemberName = "Primitive";
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackInt32ValueAsyncDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfPrimitiveDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackValueTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_PrimitivePrivateSetterPropertyAndConstructor>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
