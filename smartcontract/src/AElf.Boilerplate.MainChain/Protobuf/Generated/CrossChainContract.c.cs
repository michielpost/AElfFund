// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cross_chain_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.CrossChain {

  #region Events
  internal partial class SideChainCreatedEvent : aelf::IEvent<SideChainCreatedEvent>
  {
    public global::System.Collections.Generic.IEnumerable<SideChainCreatedEvent> GetIndexed()
    {
      return new List<SideChainCreatedEvent>
      {
      };
    }

    public SideChainCreatedEvent GetNonIndexed()
    {
      return new SideChainCreatedEvent
      {
        Creator = Creator,
        ChainId = ChainId,
      };
    }
  }

  internal partial class Disposed : aelf::IEvent<Disposed>
  {
    public global::System.Collections.Generic.IEnumerable<Disposed> GetIndexed()
    {
      return new List<Disposed>
      {
      };
    }

    public Disposed GetNonIndexed()
    {
      return new Disposed
      {
        ChainId = ChainId,
      };
    }
  }

  internal partial class SideChainLifetimeControllerChanged : aelf::IEvent<SideChainLifetimeControllerChanged>
  {
    public global::System.Collections.Generic.IEnumerable<SideChainLifetimeControllerChanged> GetIndexed()
    {
      return new List<SideChainLifetimeControllerChanged>
      {
      };
    }

    public SideChainLifetimeControllerChanged GetNonIndexed()
    {
      return new SideChainLifetimeControllerChanged
      {
        AuthorityInfo = AuthorityInfo,
      };
    }
  }

  internal partial class CrossChainIndexingControllerChanged : aelf::IEvent<CrossChainIndexingControllerChanged>
  {
    public global::System.Collections.Generic.IEnumerable<CrossChainIndexingControllerChanged> GetIndexed()
    {
      return new List<CrossChainIndexingControllerChanged>
      {
      };
    }

    public CrossChainIndexingControllerChanged GetNonIndexed()
    {
      return new CrossChainIndexingControllerChanged
      {
        AuthorityInfo = AuthorityInfo,
      };
    }
  }

  internal partial class SideChainIndexingFeeControllerChanged : aelf::IEvent<SideChainIndexingFeeControllerChanged>
  {
    public global::System.Collections.Generic.IEnumerable<SideChainIndexingFeeControllerChanged> GetIndexed()
    {
      return new List<SideChainIndexingFeeControllerChanged>
      {
      new SideChainIndexingFeeControllerChanged
      {
        ChainId = ChainId
      },
      };
    }

    public SideChainIndexingFeeControllerChanged GetNonIndexed()
    {
      return new SideChainIndexingFeeControllerChanged
      {
        AuthorityInfo = AuthorityInfo,
      };
    }
  }

  #endregion
  internal static partial class CrossChainContractContainer
  {
    static readonly string __ServiceName = "CrossChain.CrossChainContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.InitializeInput> __Marshaller_CrossChain_InitializeInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.InitializeInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AuthorityInfo> __Marshaller_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput> __Marshaller_CrossChain_ChangeSideChainIndexingFeeControllerInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput> __Marshaller_CrossChain_AcceptCrossChainIndexingProposalInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.GetChainStatusOutput> __Marshaller_CrossChain_GetChainStatusOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.GetChainStatusOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> __Marshaller_CrossChain_GetIndexingProposalStatusOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_CrossChain_InitializeInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetInitialSideChainLifetimeControllerAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetInitialSideChainLifetimeControllerAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetInitialIndexingControllerAddress = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetInitialIndexingControllerAddress",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeCrossChainIndexingController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeCrossChainIndexingController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeSideChainLifetimeController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeSideChainLifetimeController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeSideChainIndexingFeeController = new aelf::Method<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeSideChainIndexingFeeController",
        __Marshaller_CrossChain_ChangeSideChainIndexingFeeControllerInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AcceptCrossChainIndexingProposal = new aelf::Method<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AcceptCrossChainIndexingProposal",
        __Marshaller_CrossChain_AcceptCrossChainIndexingProposalInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address> __Method_GetSideChainCreator = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainCreator",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_aelf_Address);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput> __Method_GetChainStatus = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetChainStatus",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_CrossChain_GetChainStatusOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainHeight",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetParentChainHeight = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetParentChainHeight",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetParentChainId = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetParentChainId",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainBalance = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainBalance",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainIndexingFeeDebt = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeeDebt",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> __Method_GetIndexingProposalStatus = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetIndexingProposalStatus",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_CrossChain_GetIndexingProposalStatusOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetSideChainIndexingFeePrice = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeePrice",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetSideChainLifetimeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainLifetimeController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetCrossChainIndexingController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCrossChainIndexingController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo> __Method_GetSideChainIndexingFeeController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetSideChainIndexingFeeController",
        __Marshaller_google_protobuf_Int32Value,
        __Marshaller_AuthorityInfo);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.CrossChain.CrossChainContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.CrossChain.CrossChainContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class CrossChainContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.InitializeInput, global::Google.Protobuf.WellKnownTypes.Empty> Initialize
      {
        get { return __factory.Create(__Method_Initialize); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> SetInitialSideChainLifetimeControllerAddress
      {
        get { return __factory.Create(__Method_SetInitialSideChainLifetimeControllerAddress); }
      }

      public aelf::IMethodStub<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> SetInitialIndexingControllerAddress
      {
        get { return __factory.Create(__Method_SetInitialIndexingControllerAddress); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeCrossChainIndexingController
      {
        get { return __factory.Create(__Method_ChangeCrossChainIndexingController); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeSideChainLifetimeController
      {
        get { return __factory.Create(__Method_ChangeSideChainLifetimeController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.ChangeSideChainIndexingFeeControllerInput, global::Google.Protobuf.WellKnownTypes.Empty> ChangeSideChainIndexingFeeController
      {
        get { return __factory.Create(__Method_ChangeSideChainIndexingFeeController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.CrossChain.AcceptCrossChainIndexingProposalInput, global::Google.Protobuf.WellKnownTypes.Empty> AcceptCrossChainIndexingProposal
      {
        get { return __factory.Create(__Method_AcceptCrossChainIndexingProposal); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Types.Address> GetSideChainCreator
      {
        get { return __factory.Create(__Method_GetSideChainCreator); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AElf.Contracts.CrossChain.GetChainStatusOutput> GetChainStatus
      {
        get { return __factory.Create(__Method_GetChainStatus); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainHeight
      {
        get { return __factory.Create(__Method_GetSideChainHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> GetParentChainHeight
      {
        get { return __factory.Create(__Method_GetParentChainHeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> GetParentChainId
      {
        get { return __factory.Create(__Method_GetParentChainId); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainBalance
      {
        get { return __factory.Create(__Method_GetSideChainBalance); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainIndexingFeeDebt
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeeDebt); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.CrossChain.GetIndexingProposalStatusOutput> GetIndexingProposalStatus
      {
        get { return __factory.Create(__Method_GetIndexingProposalStatus); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::Google.Protobuf.WellKnownTypes.Int64Value> GetSideChainIndexingFeePrice
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeePrice); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetSideChainLifetimeController
      {
        get { return __factory.Create(__Method_GetSideChainLifetimeController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetCrossChainIndexingController
      {
        get { return __factory.Create(__Method_GetCrossChainIndexingController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Int32Value, global::AuthorityInfo> GetSideChainIndexingFeeController
      {
        get { return __factory.Create(__Method_GetSideChainIndexingFeeController); }
      }

    }
  }
}
#endregion
