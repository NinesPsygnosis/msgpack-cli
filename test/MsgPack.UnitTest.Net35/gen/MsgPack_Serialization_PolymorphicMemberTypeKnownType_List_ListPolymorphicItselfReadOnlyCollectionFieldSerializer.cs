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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, System.Collections.Generic.IList<string>> this_SetUnpackedValueOfListPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0.Add("0", typeof(System.Collections.ObjectModel.Collection<string>));
            typeMap0.Add("1", typeof(System.Collections.Generic.List<string>));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicCollection(typeof(System.Collections.Generic.IList<string>), typeMap0, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>(this.PackValueOfListPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>>(1);
            packOperationTable["ListPolymorphicItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>(this.PackValueOfListPolymorphicItself);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, bool>>(1);
            nullCheckerTable["ListPolymorphicItself"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, bool>(this.IsListPolymorphicItselfNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>>(1);
            unpackOperationTable["ListPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, int, int>(this.UnpackValueOfListPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListPolymorphicItself"};
            this.this_SetUnpackedValueOfListPolymorphicItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, System.Collections.Generic.IList<string>>(this.SetUnpackedValueOfListPolymorphicItself);
        }
        
        private void PackValueOfListPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListPolymorphicItself);
        }
        
        private bool IsListPolymorphicItselfNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField objectTree) {
            return (objectTree.ListPolymorphicItself == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>);
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
        
        private void SetUnpackedValueOfListPolymorphicItself(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField unpackingContext, System.Collections.Generic.IList<string> unpackedValue) {
            System.Collections.Generic.IList<string> existent = default(System.Collections.Generic.IList<string>);
            existent = unpackingContext.ListPolymorphicItself;
            System.Collections.Generic.IEnumerator<string> enumerator = unpackedValue.GetEnumerator();
            string current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    existent.Add(current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        private void UnpackValueOfListPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, System.Collections.Generic.IList<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField, System.Collections.Generic.IList<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<string>);
            unpackHelperParameters.MemberName = "ListPolymorphicItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListPolymorphicItselfDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItselfReadOnlyCollectionField>(), this._unpackOperationTable);
            }
        }
    }
}
