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
    public class MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer : MsgPack.Serialization.CollectionSerializers.EnumerableMessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<int[]>, int[]> {
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int[]>, int> _unpackTo;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int[]>, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> _unpackToAsync;
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer.RestoreSchema()) {
            this._unpackTo = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int[]>, int>(this.UnpackToCore);
            this._unpackToAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<int[]>, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackToAsyncCore);
        }
        
        protected override MsgPack.Serialization.AddOnlyCollection<int[]> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.AddOnlyCollection<int[]> collection = default(MsgPack.Serialization.AddOnlyCollection<int[]>);
            collection = new MsgPack.Serialization.AddOnlyCollection<int[]>();
            return collection;
        }
        
        protected override void AddItem(MsgPack.Serialization.AddOnlyCollection<int[]> collection, int[] item) {
            collection.Add(item);
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<int[]> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            MsgPack.Serialization.UnpackCollectionParameters<MsgPack.Serialization.AddOnlyCollection<int[]>> unpackHelperParameters = default(MsgPack.Serialization.UnpackCollectionParameters<MsgPack.Serialization.AddOnlyCollection<int[]>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Collection = this.CreateInstance(itemsCount);
            unpackHelperParameters.BulkOperation = this._unpackTo;
            unpackHelperParameters.EachOperation = null;
            return MsgPack.Serialization.UnpackHelpers.UnpackCollection<MsgPack.Serialization.AddOnlyCollection<int[]>>(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.AddOnlyCollection<int[]>> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            MsgPack.Serialization.UnpackCollectionAsyncParameters<MsgPack.Serialization.AddOnlyCollection<int[]>> unpackHelperParameters = default(MsgPack.Serialization.UnpackCollectionAsyncParameters<MsgPack.Serialization.AddOnlyCollection<int[]>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Collection = this.CreateInstance(itemsCount);
            unpackHelperParameters.BulkOperation = this._unpackToAsync;
            unpackHelperParameters.EachOperation = null;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackCollectionAsync<MsgPack.Serialization.AddOnlyCollection<int[]>>(ref unpackHelperParameters);
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
