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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, object>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, System.Collections.Generic.IDictionary<string, object>> this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, object>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, object>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>(this.PackValueOfDictStaticKeyAndObjectItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>>(1);
            packOperationTable["DictStaticKeyAndObjectItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>(this.PackValueOfDictStaticKeyAndObjectItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, bool>>(1);
            nullCheckerTable["DictStaticKeyAndObjectItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, bool>(this.IsDictStaticKeyAndObjectItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>(this.UnpackValueOfDictStaticKeyAndObjectItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>>(1);
            unpackOperationTable["DictStaticKeyAndObjectItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, int, int>(this.UnpackValueOfDictStaticKeyAndObjectItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "DictStaticKeyAndObjectItem"};
            this.this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, System.Collections.Generic.IDictionary<string, object>>(this.SetUnpackedValueOfDictStaticKeyAndObjectItem);
        }
        
        private void PackValueOfDictStaticKeyAndObjectItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictStaticKeyAndObjectItem);
        }
        
        private bool IsDictStaticKeyAndObjectItemNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField objectTree) {
            return (objectTree.DictStaticKeyAndObjectItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>);
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
        
        private void SetUnpackedValueOfDictStaticKeyAndObjectItem(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField unpackingContext, System.Collections.Generic.IDictionary<string, object> unpackedValue) {
            unpackingContext.DictStaticKeyAndObjectItem = unpackedValue;
        }
        
        private void UnpackValueOfDictStaticKeyAndObjectItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, System.Collections.Generic.IDictionary<string, object>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField, System.Collections.Generic.IDictionary<string, object>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IDictionary<string, object>);
            unpackHelperParameters.MemberName = "DictStaticKeyAndObjectItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictStaticKeyAndObjectItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Dict_DictStaticKeyAndObjectItemReadWriteField>(), this._unpackOperationTable);
            }
        }
    }
}
