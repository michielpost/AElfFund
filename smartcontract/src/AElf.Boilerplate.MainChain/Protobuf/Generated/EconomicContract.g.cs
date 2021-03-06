// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: economic_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AElf.Contracts.Economic {

  /// <summary>Holder for reflection information generated from economic_contract.proto</summary>
  internal static partial class EconomicContractReflection {

    #region Descriptor
    /// <summary>File descriptor for economic_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EconomicContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdlY29ub21pY19jb250cmFjdC5wcm90bxIIRWNvbm9taWMaD2FlbGYvY29y",
            "ZS5wcm90bxoSYWVsZi9vcHRpb25zLnByb3RvGhtnb29nbGUvcHJvdG9idWYv",
            "ZW1wdHkucHJvdG8ihQIKGkluaXRpYWxFY29ub21pY1N5c3RlbUlucHV0EhsK",
            "E25hdGl2ZV90b2tlbl9zeW1ib2wYASABKAkSGQoRbmF0aXZlX3Rva2VuX25h",
            "bWUYAiABKAkSIQoZbmF0aXZlX3Rva2VuX3RvdGFsX3N1cHBseRgDIAEoAxId",
            "ChVuYXRpdmVfdG9rZW5fZGVjaW1hbHMYBCABKAUSIAoYaXNfbmF0aXZlX3Rv",
            "a2VuX2J1cm5hYmxlGAUgASgIEiIKGm1pbmluZ19yZXdhcmRfdG90YWxfYW1v",
            "dW50GAYgASgDEicKH3RyYW5zYWN0aW9uX3NpemVfZmVlX3VuaXRfcHJpY2UY",
            "ByABKAMiUAoVSXNzdWVOYXRpdmVUb2tlbklucHV0Eg4KBmFtb3VudBgBIAEo",
            "AxIMCgRtZW1vGAIgASgJEhkKAnRvGAMgASgLMg0uYWVsZi5BZGRyZXNzImIK",
            "F0lzc3VlUmVzb3VyY2VUb2tlbklucHV0Eg4KBnN5bWJvbBgBIAEoCRIOCgZh",
            "bW91bnQYAiABKAMSDAoEbWVtbxgDIAEoCRIZCgJ0bxgEIAEoCzINLmFlbGYu",
            "QWRkcmVzczLuAQoQRWNvbm9taWNDb250cmFjdBJNChBJc3N1ZU5hdGl2ZVRv",
            "a2VuEh8uRWNvbm9taWMuSXNzdWVOYXRpdmVUb2tlbklucHV0GhYuZ29vZ2xl",
            "LnByb3RvYnVmLkVtcHR5IgASVwoVSW5pdGlhbEVjb25vbWljU3lzdGVtEiQu",
            "RWNvbm9taWMuSW5pdGlhbEVjb25vbWljU3lzdGVtSW5wdXQaFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkiABoyssz2AS1BRWxmLkNvbnRyYWN0cy5FY29ub21p",
            "Yy5FY29ub21pY0NvbnRyYWN0U3RhdGVCGqoCF0FFbGYuQ29udHJhY3RzLkVj",
            "b25vbWljYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AElf.Types.CoreReflection.Descriptor, global::AElf.OptionsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Economic.InitialEconomicSystemInput), global::AElf.Contracts.Economic.InitialEconomicSystemInput.Parser, new[]{ "NativeTokenSymbol", "NativeTokenName", "NativeTokenTotalSupply", "NativeTokenDecimals", "IsNativeTokenBurnable", "MiningRewardTotalAmount", "TransactionSizeFeeUnitPrice" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Economic.IssueNativeTokenInput), global::AElf.Contracts.Economic.IssueNativeTokenInput.Parser, new[]{ "Amount", "Memo", "To" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AElf.Contracts.Economic.IssueResourceTokenInput), global::AElf.Contracts.Economic.IssueResourceTokenInput.Parser, new[]{ "Symbol", "Amount", "Memo", "To" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class InitialEconomicSystemInput : pb::IMessage<InitialEconomicSystemInput> {
    private static readonly pb::MessageParser<InitialEconomicSystemInput> _parser = new pb::MessageParser<InitialEconomicSystemInput>(() => new InitialEconomicSystemInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitialEconomicSystemInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Economic.EconomicContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitialEconomicSystemInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitialEconomicSystemInput(InitialEconomicSystemInput other) : this() {
      nativeTokenSymbol_ = other.nativeTokenSymbol_;
      nativeTokenName_ = other.nativeTokenName_;
      nativeTokenTotalSupply_ = other.nativeTokenTotalSupply_;
      nativeTokenDecimals_ = other.nativeTokenDecimals_;
      isNativeTokenBurnable_ = other.isNativeTokenBurnable_;
      miningRewardTotalAmount_ = other.miningRewardTotalAmount_;
      transactionSizeFeeUnitPrice_ = other.transactionSizeFeeUnitPrice_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitialEconomicSystemInput Clone() {
      return new InitialEconomicSystemInput(this);
    }

    /// <summary>Field number for the "native_token_symbol" field.</summary>
    public const int NativeTokenSymbolFieldNumber = 1;
    private string nativeTokenSymbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NativeTokenSymbol {
      get { return nativeTokenSymbol_; }
      set {
        nativeTokenSymbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "native_token_name" field.</summary>
    public const int NativeTokenNameFieldNumber = 2;
    private string nativeTokenName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NativeTokenName {
      get { return nativeTokenName_; }
      set {
        nativeTokenName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "native_token_total_supply" field.</summary>
    public const int NativeTokenTotalSupplyFieldNumber = 3;
    private long nativeTokenTotalSupply_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long NativeTokenTotalSupply {
      get { return nativeTokenTotalSupply_; }
      set {
        nativeTokenTotalSupply_ = value;
      }
    }

    /// <summary>Field number for the "native_token_decimals" field.</summary>
    public const int NativeTokenDecimalsFieldNumber = 4;
    private int nativeTokenDecimals_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NativeTokenDecimals {
      get { return nativeTokenDecimals_; }
      set {
        nativeTokenDecimals_ = value;
      }
    }

    /// <summary>Field number for the "is_native_token_burnable" field.</summary>
    public const int IsNativeTokenBurnableFieldNumber = 5;
    private bool isNativeTokenBurnable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsNativeTokenBurnable {
      get { return isNativeTokenBurnable_; }
      set {
        isNativeTokenBurnable_ = value;
      }
    }

    /// <summary>Field number for the "mining_reward_total_amount" field.</summary>
    public const int MiningRewardTotalAmountFieldNumber = 6;
    private long miningRewardTotalAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long MiningRewardTotalAmount {
      get { return miningRewardTotalAmount_; }
      set {
        miningRewardTotalAmount_ = value;
      }
    }

    /// <summary>Field number for the "transaction_size_fee_unit_price" field.</summary>
    public const int TransactionSizeFeeUnitPriceFieldNumber = 7;
    private long transactionSizeFeeUnitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TransactionSizeFeeUnitPrice {
      get { return transactionSizeFeeUnitPrice_; }
      set {
        transactionSizeFeeUnitPrice_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitialEconomicSystemInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitialEconomicSystemInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NativeTokenSymbol != other.NativeTokenSymbol) return false;
      if (NativeTokenName != other.NativeTokenName) return false;
      if (NativeTokenTotalSupply != other.NativeTokenTotalSupply) return false;
      if (NativeTokenDecimals != other.NativeTokenDecimals) return false;
      if (IsNativeTokenBurnable != other.IsNativeTokenBurnable) return false;
      if (MiningRewardTotalAmount != other.MiningRewardTotalAmount) return false;
      if (TransactionSizeFeeUnitPrice != other.TransactionSizeFeeUnitPrice) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NativeTokenSymbol.Length != 0) hash ^= NativeTokenSymbol.GetHashCode();
      if (NativeTokenName.Length != 0) hash ^= NativeTokenName.GetHashCode();
      if (NativeTokenTotalSupply != 0L) hash ^= NativeTokenTotalSupply.GetHashCode();
      if (NativeTokenDecimals != 0) hash ^= NativeTokenDecimals.GetHashCode();
      if (IsNativeTokenBurnable != false) hash ^= IsNativeTokenBurnable.GetHashCode();
      if (MiningRewardTotalAmount != 0L) hash ^= MiningRewardTotalAmount.GetHashCode();
      if (TransactionSizeFeeUnitPrice != 0L) hash ^= TransactionSizeFeeUnitPrice.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NativeTokenSymbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NativeTokenSymbol);
      }
      if (NativeTokenName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NativeTokenName);
      }
      if (NativeTokenTotalSupply != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(NativeTokenTotalSupply);
      }
      if (NativeTokenDecimals != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NativeTokenDecimals);
      }
      if (IsNativeTokenBurnable != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsNativeTokenBurnable);
      }
      if (MiningRewardTotalAmount != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(MiningRewardTotalAmount);
      }
      if (TransactionSizeFeeUnitPrice != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(TransactionSizeFeeUnitPrice);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NativeTokenSymbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NativeTokenSymbol);
      }
      if (NativeTokenName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NativeTokenName);
      }
      if (NativeTokenTotalSupply != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NativeTokenTotalSupply);
      }
      if (NativeTokenDecimals != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NativeTokenDecimals);
      }
      if (IsNativeTokenBurnable != false) {
        size += 1 + 1;
      }
      if (MiningRewardTotalAmount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(MiningRewardTotalAmount);
      }
      if (TransactionSizeFeeUnitPrice != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TransactionSizeFeeUnitPrice);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitialEconomicSystemInput other) {
      if (other == null) {
        return;
      }
      if (other.NativeTokenSymbol.Length != 0) {
        NativeTokenSymbol = other.NativeTokenSymbol;
      }
      if (other.NativeTokenName.Length != 0) {
        NativeTokenName = other.NativeTokenName;
      }
      if (other.NativeTokenTotalSupply != 0L) {
        NativeTokenTotalSupply = other.NativeTokenTotalSupply;
      }
      if (other.NativeTokenDecimals != 0) {
        NativeTokenDecimals = other.NativeTokenDecimals;
      }
      if (other.IsNativeTokenBurnable != false) {
        IsNativeTokenBurnable = other.IsNativeTokenBurnable;
      }
      if (other.MiningRewardTotalAmount != 0L) {
        MiningRewardTotalAmount = other.MiningRewardTotalAmount;
      }
      if (other.TransactionSizeFeeUnitPrice != 0L) {
        TransactionSizeFeeUnitPrice = other.TransactionSizeFeeUnitPrice;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            NativeTokenSymbol = input.ReadString();
            break;
          }
          case 18: {
            NativeTokenName = input.ReadString();
            break;
          }
          case 24: {
            NativeTokenTotalSupply = input.ReadInt64();
            break;
          }
          case 32: {
            NativeTokenDecimals = input.ReadInt32();
            break;
          }
          case 40: {
            IsNativeTokenBurnable = input.ReadBool();
            break;
          }
          case 48: {
            MiningRewardTotalAmount = input.ReadInt64();
            break;
          }
          case 56: {
            TransactionSizeFeeUnitPrice = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class IssueNativeTokenInput : pb::IMessage<IssueNativeTokenInput> {
    private static readonly pb::MessageParser<IssueNativeTokenInput> _parser = new pb::MessageParser<IssueNativeTokenInput>(() => new IssueNativeTokenInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IssueNativeTokenInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Economic.EconomicContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueNativeTokenInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueNativeTokenInput(IssueNativeTokenInput other) : this() {
      amount_ = other.amount_;
      memo_ = other.memo_;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueNativeTokenInput Clone() {
      return new IssueNativeTokenInput(this);
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 1;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "memo" field.</summary>
    public const int MemoFieldNumber = 2;
    private string memo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Memo {
      get { return memo_; }
      set {
        memo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 3;
    private global::AElf.Types.Address to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IssueNativeTokenInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IssueNativeTokenInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Amount != other.Amount) return false;
      if (Memo != other.Memo) return false;
      if (!object.Equals(To, other.To)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (Memo.Length != 0) hash ^= Memo.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Amount != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Amount);
      }
      if (Memo.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Memo);
      }
      if (to_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(To);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Amount);
      }
      if (Memo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Memo);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IssueNativeTokenInput other) {
      if (other == null) {
        return;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      if (other.Memo.Length != 0) {
        Memo = other.Memo;
      }
      if (other.to_ != null) {
        if (to_ == null) {
          To = new global::AElf.Types.Address();
        }
        To.MergeFrom(other.To);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Amount = input.ReadInt64();
            break;
          }
          case 18: {
            Memo = input.ReadString();
            break;
          }
          case 26: {
            if (to_ == null) {
              To = new global::AElf.Types.Address();
            }
            input.ReadMessage(To);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class IssueResourceTokenInput : pb::IMessage<IssueResourceTokenInput> {
    private static readonly pb::MessageParser<IssueResourceTokenInput> _parser = new pb::MessageParser<IssueResourceTokenInput>(() => new IssueResourceTokenInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IssueResourceTokenInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AElf.Contracts.Economic.EconomicContractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueResourceTokenInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueResourceTokenInput(IssueResourceTokenInput other) : this() {
      symbol_ = other.symbol_;
      amount_ = other.amount_;
      memo_ = other.memo_;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IssueResourceTokenInput Clone() {
      return new IssueResourceTokenInput(this);
    }

    /// <summary>Field number for the "symbol" field.</summary>
    public const int SymbolFieldNumber = 1;
    private string symbol_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Symbol {
      get { return symbol_; }
      set {
        symbol_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "memo" field.</summary>
    public const int MemoFieldNumber = 3;
    private string memo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Memo {
      get { return memo_; }
      set {
        memo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 4;
    private global::AElf.Types.Address to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Types.Address To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IssueResourceTokenInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IssueResourceTokenInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Symbol != other.Symbol) return false;
      if (Amount != other.Amount) return false;
      if (Memo != other.Memo) return false;
      if (!object.Equals(To, other.To)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Symbol.Length != 0) hash ^= Symbol.GetHashCode();
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (Memo.Length != 0) hash ^= Memo.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Symbol.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Symbol);
      }
      if (Amount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Amount);
      }
      if (Memo.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Memo);
      }
      if (to_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(To);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Symbol.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Symbol);
      }
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Amount);
      }
      if (Memo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Memo);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IssueResourceTokenInput other) {
      if (other == null) {
        return;
      }
      if (other.Symbol.Length != 0) {
        Symbol = other.Symbol;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      if (other.Memo.Length != 0) {
        Memo = other.Memo;
      }
      if (other.to_ != null) {
        if (to_ == null) {
          To = new global::AElf.Types.Address();
        }
        To.MergeFrom(other.To);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Symbol = input.ReadString();
            break;
          }
          case 16: {
            Amount = input.ReadInt64();
            break;
          }
          case 26: {
            Memo = input.ReadString();
            break;
          }
          case 34: {
            if (to_ == null) {
              To = new global::AElf.Types.Address();
            }
            input.ReadMessage(To);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
