﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8689
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_WithAbstractInt32CollectionSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.WithAbstractInt32Collection> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<int>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.WithAbstractInt32Collection, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.WithAbstractInt32Collection, System.Collections.Generic.IList<int>> this_SetUnpackedValueOfCollectionDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_WithAbstractInt32CollectionSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<int>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>(this.PackValueOfCollection);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>>(1);
            packOperationTable["Collection"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.WithAbstractInt32Collection>(this.PackValueOfCollection);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractInt32Collection, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractInt32Collection, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.WithAbstractInt32Collection, bool>>(1);
            nullCheckerTable["Collection"] = new System.Func<MsgPack.Serialization.WithAbstractInt32Collection, bool>(this.IsCollectionNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>(this.UnpackValueOfCollection);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>>(1);
            unpackOperationTable["Collection"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.WithAbstractInt32Collection, int, int>(this.UnpackValueOfCollection);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Collection"};
            this.this_SetUnpackedValueOfCollectionDelegate = new System.Action<MsgPack.Serialization.WithAbstractInt32Collection, System.Collections.Generic.IList<int>>(this.SetUnpackedValueOfCollection);
        }
        
        private void PackValueOfCollection(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractInt32Collection objectTree) {
            this._serializer0.PackTo(packer, objectTree.Collection);
        }
        
        private bool IsCollectionNull(MsgPack.Serialization.WithAbstractInt32Collection objectTree) {
            return (objectTree.Collection == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.WithAbstractInt32Collection objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.WithAbstractInt32Collection> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.WithAbstractInt32Collection>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.WithAbstractInt32Collection> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.WithAbstractInt32Collection>);
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
        
        private void SetUnpackedValueOfCollection(MsgPack.Serialization.WithAbstractInt32Collection unpackingContext, System.Collections.Generic.IList<int> unpackedValue) {
            unpackingContext.Collection = unpackedValue;
        }
        
        private void UnpackValueOfCollection(MsgPack.Unpacker unpacker, MsgPack.Serialization.WithAbstractInt32Collection unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.WithAbstractInt32Collection, System.Collections.Generic.IList<int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.WithAbstractInt32Collection, System.Collections.Generic.IList<int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<int>);
            unpackHelperParameters.MemberName = "Collection";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfCollectionDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.WithAbstractInt32Collection UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.WithAbstractInt32Collection result = default(MsgPack.Serialization.WithAbstractInt32Collection);
            result = new MsgPack.Serialization.WithAbstractInt32Collection();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractInt32Collection>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.WithAbstractInt32Collection>(), this._unpackOperationTable);
            }
        }
    }
}
