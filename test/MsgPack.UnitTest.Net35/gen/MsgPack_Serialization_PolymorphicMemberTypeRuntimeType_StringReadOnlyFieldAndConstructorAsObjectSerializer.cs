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
    public class MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObjectSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject> {
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject, bool>> _nullCheckersTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, object> this_SetUnpackedValueOfStringDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObjectSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<object>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>(this.PackValueOfString);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>>(1);
            packOperationTable["String"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>(this.PackValueOfString);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject, bool>>(1);
            nullCheckerTable["String"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject, bool>(this.IsStringNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfString);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>>(1);
            unpackOperationTable["String"] = new System.Action<MsgPack.Unpacker, UnpackingContext, int, int>(this.UnpackValueOfString);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "String"};
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfStringDelegate = new System.Action<UnpackingContext, object>(this.SetUnpackedValueOfString);
        }
        
        private void PackValueOfString(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject objectTree) {
            this._serializer0.PackTo(packer, objectTree.String);
        }
        
        private bool IsStringNull(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject objectTree) {
            return (objectTree.String == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject>);
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
        
        private MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject result = default(MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject);
            result = new MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject(unpackingContext.String);
            return result;
        }
        
        private void SetUnpackedValueOfString(UnpackingContext unpackingContext, object unpackedValue) {
            unpackingContext.String = unpackedValue;
        }
        
        private void UnpackValueOfString(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, object> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, object>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(object);
            unpackHelperParameters.MemberName = "String";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfStringDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeRuntimeType_StringReadOnlyFieldAndConstructorAsObject UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            object ctorArg0 = default(object);
            ctorArg0 = null;
            unpackingContext = new UnpackingContext(ctorArg0);
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, unpackingContext, this.this_CreateInstanceFromContextDelegate, this._unpackOperationTable);
            }
        }
        
        public class UnpackingContext {
            
            public object String;
            
            public UnpackingContext(object String) {
                this.String = String;
            }
        }
    }
}
