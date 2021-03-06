// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: parliament_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Parliament {

  #region Events
  #endregion
  internal static partial class ParliamentContractContainer
  {
    static readonly string __ServiceName = "Parliament.ParliamentContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.Parliament.InitializeInput> __Marshaller_Parliament_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Parliament.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Parliament.CreateOrganizationInput> __Marshaller_Parliament_CreateOrganizationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Parliament.CreateOrganizationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Parliament.ProposalIdList> __Marshaller_Parliament_ProposalIdList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Parliament.ProposalIdList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Parliament.CreateOrganizationBySystemContractInput> __Marshaller_Parliament_CreateOrganizationBySystemContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Parliament.CreateOrganizationBySystemContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Parliament.Organization> __Marshaller_Parliament_Organization = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Parliament.Organization.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.BoolValue> __Marshaller_google_protobuf_BoolValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.BoolValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Standards.ACS3.ProposerWhiteList> __Marshaller_acs3_ProposerWhiteList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Standards.ACS3.ProposerWhiteList.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.Parliament.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Contracts.Parliament.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_Parliament_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address> __Method_CreateOrganization = new aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateOrganization",
        __Marshaller_Parliament_CreateOrganizationInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ApproveMultiProposals = new aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ApproveMultiProposals",
        __Marshaller_Parliament_ProposalIdList,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationBySystemContractInput, global::AElf.Types.Address> __Method_CreateOrganizationBySystemContract = new aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationBySystemContractInput, global::AElf.Types.Address>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateOrganizationBySystemContract",
        __Marshaller_Parliament_CreateOrganizationBySystemContractInput,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Parliament.Organization> __Method_GetOrganization = new aelf::Method<global::AElf.Types.Address, global::AElf.Contracts.Parliament.Organization>(
        aelf::MethodType.View,
        __ServiceName,
        "GetOrganization",
        __Marshaller_aelf_Address,
        __Marshaller_Parliament_Organization);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> __Method_GetDefaultOrganizationAddress = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDefaultOrganizationAddress",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> __Method_ValidateAddressIsParliamentMember = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue>(
        aelf::MethodType.View,
        __ServiceName,
        "ValidateAddressIsParliamentMember",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_BoolValue);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS3.ProposerWhiteList> __Method_GetProposerWhiteList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS3.ProposerWhiteList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProposerWhiteList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_acs3_ProposerWhiteList);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList> __Method_GetNotVotedPendingProposals = new aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetNotVotedPendingProposals",
        __Marshaller_Parliament_ProposalIdList,
        __Marshaller_Parliament_ProposalIdList);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList> __Method_GetNotVotedProposals = new aelf::Method<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetNotVotedProposals",
        __Marshaller_Parliament_ProposalIdList,
        __Marshaller_Parliament_ProposalIdList);

    static readonly aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address> __Method_CalculateOrganizationAddress = new aelf::Method<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "CalculateOrganizationAddress",
        __Marshaller_Parliament_CreateOrganizationInput,
        __Marshaller_aelf_Address);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Parliament.ParliamentContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Parliament.ParliamentContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ParliamentContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.Parliament.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> Initialize
      {
        get { return __factory.Create(__Method_Initialize); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address> CreateOrganization
      {
        get { return __factory.Create(__Method_CreateOrganization); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.ProposalIdList, global::Google.Protobuf.WellKnownTypes.Empty> ApproveMultiProposals
      {
        get { return __factory.Create(__Method_ApproveMultiProposals); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.CreateOrganizationBySystemContractInput, global::AElf.Types.Address> CreateOrganizationBySystemContract
      {
        get { return __factory.Create(__Method_CreateOrganizationBySystemContract); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::AElf.Contracts.Parliament.Organization> GetOrganization
      {
        get { return __factory.Create(__Method_GetOrganization); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Address> GetDefaultOrganizationAddress
      {
        get { return __factory.Create(__Method_GetDefaultOrganizationAddress); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.BoolValue> ValidateAddressIsParliamentMember
      {
        get { return __factory.Create(__Method_ValidateAddressIsParliamentMember); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Standards.ACS3.ProposerWhiteList> GetProposerWhiteList
      {
        get { return __factory.Create(__Method_GetProposerWhiteList); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList> GetNotVotedPendingProposals
      {
        get { return __factory.Create(__Method_GetNotVotedPendingProposals); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.ProposalIdList, global::AElf.Contracts.Parliament.ProposalIdList> GetNotVotedProposals
      {
        get { return __factory.Create(__Method_GetNotVotedProposals); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Parliament.CreateOrganizationInput, global::AElf.Types.Address> CalculateOrganizationAddress
      {
        get { return __factory.Create(__Method_CalculateOrganizationAddress); }
      }

    }
  }
}
#endregion

