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
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor, bool>> _nullCheckersTable;
        
        private System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor> this_CreateInstanceFromContextDelegate;
        
        private System.Action<UnpackingContext, string> this_SetUnpackedValueOfStringDelegate;
        
        private System.Func<MsgPack.Unpacker, System.Type, string, string> MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, UnpackingContext, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>(this.PackValueOfString);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>>(1);
            packOperationTable["String"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>(this.PackValueOfString);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor, bool>>(1);
            nullCheckerTable["String"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor, bool>(this.IsStringNull);
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
            this.this_CreateInstanceFromContextDelegate = new System.Func<UnpackingContext, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>(this.CreateInstanceFromContext);
            this.this_SetUnpackedValueOfStringDelegate = new System.Action<UnpackingContext, string>(this.SetUnpackedValueOfString);
            this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate = new System.Func<MsgPack.Unpacker, System.Type, string, string>(MsgPack.Serialization.UnpackHelpers.UnpackStringValue);
        }
        
        private void PackValueOfString(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor objectTree) {
            this._serializer0.PackTo(packer, objectTree.String);
        }
        
        private bool IsStringNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor objectTree) {
            return (objectTree.String == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor>);
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
        
        private MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor CreateInstanceFromContext(UnpackingContext unpackingContext) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor(unpackingContext.String);
            return result;
        }
        
        private void SetUnpackedValueOfString(UnpackingContext unpackingContext, string unpackedValue) {
            unpackingContext.String = unpackedValue;
        }
        
        private void UnpackValueOfString(MsgPack.Unpacker unpacker, UnpackingContext unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, string> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<UnpackingContext, string>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(string);
            unpackHelperParameters.MemberName = "String";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = this.MsgPack_Serialization_UnpackHelpers_UnpackStringValueDelegate;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfStringDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Normal_StringGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            UnpackingContext unpackingContext = default(UnpackingContext);
            string ctorArg0 = default(string);
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
            
            public string String;
            
            public UnpackingContext(string String) {
                this.String = String;
            }
        }
    }
}
