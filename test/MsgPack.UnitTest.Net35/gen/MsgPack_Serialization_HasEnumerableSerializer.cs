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
    public class MsgPack_Serialization_HasEnumerableSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.HasEnumerable> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IEnumerable<int>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.HasEnumerable, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.HasEnumerable, System.Collections.Generic.IEnumerable<int>> this_SetUnpackedValueOfNumbersDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_HasEnumerableSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IEnumerable<int>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>(this.PackValueOfNumbers);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>>(1);
            packOperationTable["Numbers"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.HasEnumerable>(this.PackValueOfNumbers);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.HasEnumerable, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.HasEnumerable, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.HasEnumerable, bool>>(1);
            nullCheckerTable["Numbers"] = new System.Func<MsgPack.Serialization.HasEnumerable, bool>(this.IsNumbersNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>(this.UnpackValueOfNumbers);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>>(1);
            unpackOperationTable["Numbers"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.HasEnumerable, int, int>(this.UnpackValueOfNumbers);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "Numbers"};
            this.this_SetUnpackedValueOfNumbersDelegate = new System.Action<MsgPack.Serialization.HasEnumerable, System.Collections.Generic.IEnumerable<int>>(this.SetUnpackedValueOfNumbers);
        }
        
        private void PackValueOfNumbers(MsgPack.Packer packer, MsgPack.Serialization.HasEnumerable objectTree) {
            this._serializer0.PackTo(packer, objectTree.Numbers);
        }
        
        private bool IsNumbersNull(MsgPack.Serialization.HasEnumerable objectTree) {
            return (objectTree.Numbers == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.HasEnumerable objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.HasEnumerable> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.HasEnumerable>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.HasEnumerable> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.HasEnumerable>);
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
        
        private void SetUnpackedValueOfNumbers(MsgPack.Serialization.HasEnumerable unpackingContext, System.Collections.Generic.IEnumerable<int> unpackedValue) {
            unpackingContext.Numbers = unpackedValue;
        }
        
        private void UnpackValueOfNumbers(MsgPack.Unpacker unpacker, MsgPack.Serialization.HasEnumerable unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.HasEnumerable, System.Collections.Generic.IEnumerable<int>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.HasEnumerable, System.Collections.Generic.IEnumerable<int>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IEnumerable<int>);
            unpackHelperParameters.MemberName = "Numbers";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfNumbersDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.HasEnumerable UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.HasEnumerable result = default(MsgPack.Serialization.HasEnumerable);
            result = new MsgPack.Serialization.HasEnumerable();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.HasEnumerable>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.HasEnumerable>(), this._unpackOperationTable);
            }
        }
    }
}
