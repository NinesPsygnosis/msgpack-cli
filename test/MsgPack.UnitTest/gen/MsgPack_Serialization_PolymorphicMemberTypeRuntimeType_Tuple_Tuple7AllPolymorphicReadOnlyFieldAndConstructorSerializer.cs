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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, bool>> _nullCheckersTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _packOperationTableAsync;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> this_SetUnpackedValueOfTuple7AllPolymorphicDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        private System.Collections.Generic.IList<System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationListAsync;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> _unpackOperationTableAsync;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry));
            tupleItemsSchema0[6] = tupleItemSchema6;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>(this.PackValueOfTuple7AllPolymorphic);
            this._packOperationList = packOperationList;
            System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] packOperationListAsync = default(System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            packOperationListAsync = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            packOperationListAsync[0] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple7AllPolymorphicAsync);
            this._packOperationListAsync = packOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>>(1);
            packOperationTable["Tuple7AllPolymorphic"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>(this.PackValueOfTuple7AllPolymorphic);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>> packOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            packOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            packOperationTableAsync["Tuple7AllPolymorphic"] = new System.Func<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.PackValueOfTuple7AllPolymorphicAsync);
            this._packOperationTableAsync = packOperationTableAsync;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, bool>>(1);
            nullCheckerTable["Tuple7AllPolymorphic"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor, bool>(this.IsTuple7AllPolymorphicNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple7AllPolymorphic);
            this._unpackOperationList = unpackOperationList;
            System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[] unpackOperationListAsync = default(System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[]);
            unpackOperationListAsync = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>[1];
            unpackOperationListAsync[0] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple7AllPolymorphicAsync);
            this._unpackOperationListAsync = unpackOperationListAsync;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["Tuple7AllPolymorphic"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfTuple7AllPolymorphic);
            this._unpackOperationTable = unpackOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>> unpackOperationTableAsync = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>);
            unpackOperationTableAsync = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>>(1);
            unpackOperationTableAsync["Tuple7AllPolymorphic"] = new System.Func<MsgPack.Unpacker, UnpackingContext, int, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackValueOfTuple7AllPolymorphicAsync);
            this._unpackOperationTableAsync = unpackOperationTableAsync;
            this._memberNames = new string[] {
                    "Tuple7AllPolymorphic"};
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate = new System.Action<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(this.SetUnpackedValueOfTuple7AllPolymorphic);
        }
        
        private void PackValueOfTuple7AllPolymorphic(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.Tuple7AllPolymorphic);
        }
        
        private bool IsTuple7AllPolymorphicNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor objectTree) {
            return (objectTree.Tuple7AllPolymorphic == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>);
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
        
        private System.Threading.Tasks.Task PackValueOfTuple7AllPolymorphicAsync(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            return this._serializer0.PackToAsync(packer, objectTree.Tuple7AllPolymorphic, cancellationToken);
        }
        
        protected internal override System.Threading.Tasks.Task PackToAsyncCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor objectTree, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationListAsync;
            packHelperParameters.CancellationToken = cancellationToken;
            MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapAsyncParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor>);
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
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor(unpackingContext.Tuple7AllPolymorphic);
            return result;
        }
        
        private void SetUnpackedValueOfTuple7AllPolymorphic(UnpackingContext unpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> unpackedValue) {
            unpackingContext.Tuple7AllPolymorphic = unpackedValue;
        }
        
        private void UnpackValueOfTuple7AllPolymorphic(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
            unpackHelperParameters.MemberName = "Tuple7AllPolymorphic";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> ctorArg0 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        private System.Threading.Tasks.Task UnpackValueOfTuple7AllPolymorphicAsync(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount, System.Threading.CancellationToken cancellationToken) {
            MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueAsyncParameters<UnpackingContext, System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
            unpackHelperParameters.MemberName = "Tuple7AllPolymorphic";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfTuple7AllPolymorphicDelegate;
            unpackHelperParameters.CancellationToken = cancellationToken;
            return MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValueAsync(ref unpackHelperParameters);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_Tuple_Tuple7AllPolymorphicReadOnlyFieldAndConstructor> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> ctorArg0 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
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
            
            public System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> Tuple7AllPolymorphic;
            
            public UnpackingContext(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> Tuple7AllPolymorphic) {
                this.Tuple7AllPolymorphic = Tuple7AllPolymorphic;
            }
        }
    }
}
