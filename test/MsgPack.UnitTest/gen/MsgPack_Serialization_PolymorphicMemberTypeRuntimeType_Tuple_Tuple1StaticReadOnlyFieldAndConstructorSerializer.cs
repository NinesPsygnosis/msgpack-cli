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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<string>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.Tuple<string>> this_SetUnpackedValueOfTuple1StaticDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[1];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = null;
            tupleItemsSchema0[0] = tupleItemSchema0;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<string>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<string>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>(this.PackValueOfTuple1Static);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple1StaticAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>>(1);
            packOperationTable["Tuple1Static"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>(this.PackValueOfTuple1Static);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Tuple1Static"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple1StaticAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, bool>>(1);
            nullCheckerTable["Tuple1Static"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor, bool>(this.IsTuple1StaticNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple1Static);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple1StaticAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["Tuple1Static"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple1Static);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Tuple1Static"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple1StaticAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Tuple1Static"};
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfTuple1StaticDelegate = new System.Action<UnpackingContext, System.Tuple<string>>(this.SetUnpackedValueOfTuple1Static);
        }
        
        private void PackValueOfTuple1Static(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple1Static);
        }
        
        private bool IsTuple1StaticNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor objectTree) {
            return (objectTree.Tuple1Static == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>);
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
        
        private System.Threading.Tasks.Task PackValueOfTuple1StaticAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Tuple1Static, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor>);
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
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor(unpackingContext.Tuple1Static);
            return result;
        }
        
        private void SetUnpackedValueOfTuple1Static(UnpackingContext unpackingContext, System.Tuple<string> unpackedValue) {
            unpackingContext.Tuple1Static = unpackedValue;
        }
        
        private void UnpackValueOfTuple1Static(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Tuple<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Tuple<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Tuple<string>);
            unpackHelperParameters.MemberName = "Tuple1Static";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple1StaticDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<string> ctorArg0 = default(System.Tuple<string>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTuple1StaticAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Tuple<string>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Tuple<string>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Tuple<string>);
            unpackHelperParameters.MemberName = "Tuple1Static";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple1StaticDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple1StaticReadOnlyFieldAndConstructor> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<string> ctorArg0 = default(System.Tuple<string>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArrayAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationListAsync, cancellationToken);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMapAsync(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTableAsync, cancellationToken);
            }
        }
        
        public class UnpackingContext {
            
            public System.Tuple<string> Tuple1Static;
            
            public UnpackingContext(System.Tuple<string> Tuple1Static) {
                this.Tuple1Static = Tuple1Static;
            }
        }
    }
}
