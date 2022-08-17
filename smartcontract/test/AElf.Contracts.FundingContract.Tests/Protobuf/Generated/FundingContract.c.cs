// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: funding_contract.proto
// </auto-generated>
// Original file comments:
// This files is part of the Hello World smart contract example that is included in Boilerplate.
// It is only the definition of the contract, implementation is located in the "contract" folder
// and tests are located in the "test" folder.
//
// You can use this as a basic template for new contracts.
// 
// When building Boilerplate or the contract project located in the "../contract/AElf.Contracts.FundingContract/" 
// protoc (the protobuf compiler) will be invoked and this file will produce a .c.cs file and .g.cs file, in the 
// "../contract/AElf.Contracts.FundingContract/Protobuf/Generated/" folder. 
//
// the version of the language, use proto3 for contracts
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.FundingContract {

  #region Events
  #endregion
  /// <summary>
  /// the contract definition: a gRPC service definition.
  /// </summary>
  internal static partial class FundingContractContainer
  {
    static readonly string __ServiceName = "FundingContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.FundingContract.CreateProjectInput> __Marshaller_CreateProjectInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.FundingContract.CreateProjectInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.FundingContract.Project> __Marshaller_Project = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.FundingContract.Project.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.FundingContract.FundInput> __Marshaller_FundInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.FundingContract.FundInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.FundingContract.ProjectList> __Marshaller_ProjectList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.FundingContract.ProjectList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.FundingContract.FunderList> __Marshaller_FunderList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.FundingContract.FunderList.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.FundingContract.CreateProjectInput, global::AElf.Contracts.FundingContract.Project> __Method_CreateProject = new aelf::Method<global::AElf.Contracts.FundingContract.CreateProjectInput, global::AElf.Contracts.FundingContract.Project>(
        aelf::MethodType.Action,
        __ServiceName,
        "CreateProject",
        __Marshaller_CreateProjectInput,
        __Marshaller_Project);

    static readonly aelf::Method<global::AElf.Contracts.FundingContract.FundInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_FundProject = new aelf::Method<global::AElf.Contracts.FundingContract.FundInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "FundProject",
        __Marshaller_FundInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.ProjectList> __Method_GetProjectList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.ProjectList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetProjectList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_ProjectList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.FunderList> __Method_GetFunderList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.FunderList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetFunderList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_FunderList);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.FundingContract.FundingContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.FundingContract.FundingContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class FundingContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.FundingContract.CreateProjectInput, global::AElf.Contracts.FundingContract.Project> CreateProject
      {
        get { return __factory.Create(__Method_CreateProject); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.FundingContract.FundInput, global::Google.Protobuf.WellKnownTypes.Empty> FundProject
      {
        get { return __factory.Create(__Method_FundProject); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.ProjectList> GetProjectList
      {
        get { return __factory.Create(__Method_GetProjectList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.FundingContract.FunderList> GetFunderList
      {
        get { return __factory.Create(__Method_GetFunderList); }
      }

    }
  }
}
#endregion
