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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema keysSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            keysSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>), keysSchema0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>>(1);
            packOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>(this.PackValueOfDictPolymorphicKeyAndStaticItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, bool>>(1);
            nullCheckerTable["DictPolymorphicKeyAndStaticItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, bool>(this.IsDictPolymorphicKeyAndStaticItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>>(1);
            unpackOperationTable["DictPolymorphicKeyAndStaticItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, int, int>(this.UnpackValueOfDictPolymorphicKeyAndStaticItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictPolymorphicKeyAndStaticItem"};
            this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>(this.SetUnpackedValueOfDictPolymorphicKeyAndStaticItem);
        }
        
        private void PackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicKeyAndStaticItem);
        }
        
        private bool IsDictPolymorphicKeyAndStaticItemNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField objectTree) {
            return (objectTree.DictPolymorphicKeyAndStaticItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>);
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
        
        private void SetUnpackedValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField unpackingContext, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> unpackedValue) {
            System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string> existent = default(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>);
            existent = unpackingContext.DictPolymorphicKeyAndStaticItem;
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, string>> enumerator = unpackedValue.GetEnumerator();
            System.Collections.Generic.KeyValuePair<MsgPack.Serialization.FileSystemEntry, string> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current.Key, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfDictPolymorphicKeyAndStaticItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField, System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IDictionary<MsgPack.Serialization.FileSystemEntry, string>);
            unpackHelperParameters.MemberName = "DictPolymorphicKeyAndStaticItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictPolymorphicKeyAndStaticItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictPolymorphicKeyAndStaticItemReadOnlyCollectionField>(), this._unpackOperationTable);
            }
        }
    }
}
