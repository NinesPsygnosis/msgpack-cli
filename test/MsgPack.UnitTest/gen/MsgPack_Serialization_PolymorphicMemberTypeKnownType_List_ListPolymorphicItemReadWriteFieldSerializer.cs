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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfListPolymorphicItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> itemsSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            itemsSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            itemsSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            itemsSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), itemsSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(this.PackValueOfListPolymorphicItem);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItemAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>>(1);
            packOperationTable["ListPolymorphicItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(this.PackValueOfListPolymorphicItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["ListPolymorphicItem"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfListPolymorphicItemAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, bool>>(1);
            nullCheckerTable["ListPolymorphicItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, bool>(this.IsListPolymorphicItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>(this.UnpackValueOfListPolymorphicItem);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItemAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>>(1);
            unpackOperationTable["ListPolymorphicItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int>(this.UnpackValueOfListPolymorphicItem);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["ListPolymorphicItem"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfListPolymorphicItemAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "ListPolymorphicItem"};
            this.this_SetUnpackedValueOfListPolymorphicItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfListPolymorphicItem);
        }
        
        private void PackValueOfListPolymorphicItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListPolymorphicItem);
        }
        
        private bool IsListPolymorphicItemNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField objectTree) {
            return (objectTree.ListPolymorphicItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>);
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
        
        private System.Threading.Tasks.Task PackValueOfListPolymorphicItemAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.ListPolymorphicItem, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>);
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
        
        private void SetUnpackedValueOfListPolymorphicItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField unpackingContext, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            unpackingContext.ListPolymorphicItem = unpackedValue;
        }
        
        private void UnpackValueOfListPolymorphicItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>);
            unpackHelperParameters.MemberName = "ListPolymorphicItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListPolymorphicItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfListPolymorphicItemAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField, System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<MsgPack.Serialization.FileSystemEntry>);
            unpackHelperParameters.MemberName = "ListPolymorphicItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListPolymorphicItemDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListPolymorphicItemReadWriteField>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
