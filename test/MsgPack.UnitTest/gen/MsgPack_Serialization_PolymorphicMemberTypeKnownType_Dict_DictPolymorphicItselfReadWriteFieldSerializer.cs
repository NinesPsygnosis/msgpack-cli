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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>> this_SetUnpackedValueOfDictPolymorphicItselfDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> typeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            typeMap0.Add("0", typeof(System.Collections.Generic.Dictionary<string, string>));
            typeMap0.Add("1", typeof(System.Collections.Generic.SortedDictionary<string, string>));
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicDictionary(typeof(System.Collections.Generic.IDictionary<string, string>), typeMap0, null, null);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IDictionary<string, string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(this.PackValueOfDictPolymorphicItself);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicItselfAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>>(1);
            packOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(this.PackValueOfDictPolymorphicItself);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["DictPolymorphicItself"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfDictPolymorphicItselfAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, bool>>(1);
            nullCheckerTable["DictPolymorphicItself"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, bool>(this.IsDictPolymorphicItselfNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicItselfAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>>(1);
            unpackOperationTable["DictPolymorphicItself"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int>(this.UnpackValueOfDictPolymorphicItself);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["DictPolymorphicItself"] = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfDictPolymorphicItselfAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "DictPolymorphicItself"};
            this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>>(this.SetUnpackedValueOfDictPolymorphicItself);
        }
        
        private void PackValueOfDictPolymorphicItself(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.DictPolymorphicItself);
        }
        
        private bool IsDictPolymorphicItselfNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField objectTree) {
            return (objectTree.DictPolymorphicItself == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>);
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
        
        private System.Threading.Tasks.Task PackValueOfDictPolymorphicItselfAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.DictPolymorphicItself, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>);
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
        
        private void SetUnpackedValueOfDictPolymorphicItself(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField unpackingContext, System.Collections.Generic.IDictionary<string, string> unpackedValue) {
            unpackingContext.DictPolymorphicItself = unpackedValue;
        }
        
        private void UnpackValueOfDictPolymorphicItself(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IDictionary<string, string>);
            unpackHelperParameters.MemberName = "DictPolymorphicItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(), this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfDictPolymorphicItselfAsync(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField, System.Collections.Generic.IDictionary<string, string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IDictionary<string, string>);
            unpackHelperParameters.MemberName = "DictPolymorphicItself";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfDictPolymorphicItselfDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(), this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictPolymorphicItselfReadWriteField>(), this._unpackOperationTableAsync, cancellationToken);
            }
        }
    }
}
