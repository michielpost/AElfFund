// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: election_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.Election {

  #region Events
  internal partial class EvilMinerDetected : aelf::IEvent<EvilMinerDetected>
  {
    public global::System.Collections.Generic.IEnumerable<EvilMinerDetected> GetIndexed()
    {
      return new List<EvilMinerDetected>
      {
      };
    }

    public EvilMinerDetected GetNonIndexed()
    {
      return new EvilMinerDetected
      {
        Pubkey = Pubkey,
      };
    }
  }

  #endregion
  internal static partial class ElectionContractContainer
  {
    static readonly string __ServiceName = "Election.ElectionContract";

    #region Marshallers
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.InitialElectionContractInput> __Marshaller_Election_InitialElectionContractInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.InitialElectionContractInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.TakeElectionSnapshotInput> __Marshaller_Election_TakeElectionSnapshotInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.TakeElectionSnapshotInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.VoteMinerInput> __Marshaller_Election_VoteMinerInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.VoteMinerInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Hash> __Marshaller_aelf_Hash = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Hash.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.ChangeVotingOptionInput> __Marshaller_Election_ChangeVotingOptionInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.ChangeVotingOptionInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.UpdateCandidateInformationInput> __Marshaller_Election_UpdateCandidateInformationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.UpdateCandidateInformationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.UpdateMultipleCandidateInformationInput> __Marshaller_Election_UpdateMultipleCandidateInformationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.UpdateMultipleCandidateInformationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.UpdateMinersCountInput> __Marshaller_Election_UpdateMinersCountInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.UpdateMinersCountInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.SetTreasurySchemeIdsInput> __Marshaller_Election_SetTreasurySchemeIdsInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.SetTreasurySchemeIdsInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.VoteWeightInterestList> __Marshaller_Election_VoteWeightInterestList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.VoteWeightInterestList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.VoteWeightProportion> __Marshaller_Election_VoteWeightProportion = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.VoteWeightProportion.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AuthorityInfo> __Marshaller_AuthorityInfo = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AuthorityInfo.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.PubkeyList> __Marshaller_Election_PubkeyList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.PubkeyList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.CandidateInformation> __Marshaller_Election_CandidateInformation = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.CandidateInformation.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.GetTermSnapshotInput> __Marshaller_Election_GetTermSnapshotInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.GetTermSnapshotInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.TermSnapshot> __Marshaller_Election_TermSnapshot = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.TermSnapshot.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.GetElectionResultInput> __Marshaller_Election_GetElectionResultInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.GetElectionResultInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.ElectionResult> __Marshaller_Election_ElectionResult = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.ElectionResult.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.ElectorVote> __Marshaller_Election_ElectorVote = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.ElectorVote.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.CandidateVote> __Marshaller_Election_CandidateVote = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.CandidateVote.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.PageInformation> __Marshaller_Election_PageInformation = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.PageInformation.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.GetPageableCandidateInformationOutput> __Marshaller_Election_GetPageableCandidateInformationOutput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.GetPageableCandidateInformationOutput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.DataCenterRankingList> __Marshaller_Election_DataCenterRankingList = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.DataCenterRankingList.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.VoteInformation> __Marshaller_Election_VoteInformation = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.VoteInformation.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.GetMinerReplacementInformationInput> __Marshaller_Election_GetMinerReplacementInformationInput = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.GetMinerReplacementInformationInput.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.Election.MinerReplacementInformation> __Marshaller_Election_MinerReplacementInformation = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.Election.MinerReplacementInformation.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::AElf.Contracts.Election.InitialElectionContractInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_InitialElectionContract = new aelf::Method<global::AElf.Contracts.Election.InitialElectionContractInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "InitialElectionContract",
        __Marshaller_Election_InitialElectionContractInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_RegisterElectionVotingEvent = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "RegisterElectionVotingEvent",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.TakeElectionSnapshotInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_TakeSnapshot = new aelf::Method<global::AElf.Contracts.Election.TakeElectionSnapshotInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "TakeSnapshot",
        __Marshaller_Election_TakeElectionSnapshotInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_AnnounceElection = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "AnnounceElection",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_QuitElection = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "QuitElection",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.VoteMinerInput, global::AElf.Types.Hash> __Method_Vote = new aelf::Method<global::AElf.Contracts.Election.VoteMinerInput, global::AElf.Types.Hash>(
        aelf::MethodType.Action,
        __ServiceName,
        "Vote",
        __Marshaller_Election_VoteMinerInput,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::AElf.Contracts.Election.ChangeVotingOptionInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeVotingOption = new aelf::Method<global::AElf.Contracts.Election.ChangeVotingOptionInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeVotingOption",
        __Marshaller_Election_ChangeVotingOptionInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Withdraw = new aelf::Method<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Withdraw",
        __Marshaller_aelf_Hash,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.UpdateCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCandidateInformation = new aelf::Method<global::AElf.Contracts.Election.UpdateCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateCandidateInformation",
        __Marshaller_Election_UpdateCandidateInformationInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.UpdateMultipleCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateMultipleCandidateInformation = new aelf::Method<global::AElf.Contracts.Election.UpdateMultipleCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateMultipleCandidateInformation",
        __Marshaller_Election_UpdateMultipleCandidateInformationInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.UpdateMinersCountInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateMinersCount = new aelf::Method<global::AElf.Contracts.Election.UpdateMinersCountInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "UpdateMinersCount",
        __Marshaller_Election_UpdateMinersCountInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.SetTreasurySchemeIdsInput, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetTreasurySchemeIds = new aelf::Method<global::AElf.Contracts.Election.SetTreasurySchemeIdsInput, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetTreasurySchemeIds",
        __Marshaller_Election_SetTreasurySchemeIdsInput,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.VoteWeightInterestList, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetVoteWeightInterest = new aelf::Method<global::AElf.Contracts.Election.VoteWeightInterestList, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetVoteWeightInterest",
        __Marshaller_Election_VoteWeightInterestList,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Contracts.Election.VoteWeightProportion, global::Google.Protobuf.WellKnownTypes.Empty> __Method_SetVoteWeightProportion = new aelf::Method<global::AElf.Contracts.Election.VoteWeightProportion, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "SetVoteWeightProportion",
        __Marshaller_Election_VoteWeightProportion,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> __Method_ChangeVoteWeightInterestController = new aelf::Method<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "ChangeVoteWeightInterestController",
        __Marshaller_AuthorityInfo,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> __Method_GetCandidates = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCandidates",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_PubkeyList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> __Method_GetVotedCandidates = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVotedCandidates",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_PubkeyList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateInformation> __Method_GetCandidateInformation = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateInformation>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCandidateInformation",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_CandidateInformation);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> __Method_GetVictories = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVictories",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_PubkeyList);

    static readonly aelf::Method<global::AElf.Contracts.Election.GetTermSnapshotInput, global::AElf.Contracts.Election.TermSnapshot> __Method_GetTermSnapshot = new aelf::Method<global::AElf.Contracts.Election.GetTermSnapshotInput, global::AElf.Contracts.Election.TermSnapshot>(
        aelf::MethodType.View,
        __ServiceName,
        "GetTermSnapshot",
        __Marshaller_Election_GetTermSnapshotInput,
        __Marshaller_Election_TermSnapshot);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_GetMinersCount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinersCount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int32Value);

    static readonly aelf::Method<global::AElf.Contracts.Election.GetElectionResultInput, global::AElf.Contracts.Election.ElectionResult> __Method_GetElectionResult = new aelf::Method<global::AElf.Contracts.Election.GetElectionResultInput, global::AElf.Contracts.Election.ElectionResult>(
        aelf::MethodType.View,
        __ServiceName,
        "GetElectionResult",
        __Marshaller_Election_GetElectionResultInput,
        __Marshaller_Election_ElectionResult);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> __Method_GetElectorVote = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetElectorVote",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_ElectorVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> __Method_GetElectorVoteWithRecords = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetElectorVoteWithRecords",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_ElectorVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> __Method_GetElectorVoteWithAllRecords = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetElectorVoteWithAllRecords",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_ElectorVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> __Method_GetCandidateVote = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCandidateVote",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_CandidateVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> __Method_GetCandidateVoteWithRecords = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCandidateVoteWithRecords",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_CandidateVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> __Method_GetCandidateVoteWithAllRecords = new aelf::Method<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCandidateVoteWithAllRecords",
        __Marshaller_google_protobuf_StringValue,
        __Marshaller_Election_CandidateVote);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetVotersCount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVotersCount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetVotesAmount = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVotesAmount",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::AElf.Contracts.Election.PageInformation, global::AElf.Contracts.Election.GetPageableCandidateInformationOutput> __Method_GetPageableCandidateInformation = new aelf::Method<global::AElf.Contracts.Election.PageInformation, global::AElf.Contracts.Election.GetPageableCandidateInformationOutput>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPageableCandidateInformation",
        __Marshaller_Election_PageInformation,
        __Marshaller_Election_GetPageableCandidateInformationOutput);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash> __Method_GetMinerElectionVotingItemId = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinerElectionVotingItemId",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_aelf_Hash);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.DataCenterRankingList> __Method_GetDataCenterRankingList = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.DataCenterRankingList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetDataCenterRankingList",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_DataCenterRankingList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightInterestList> __Method_GetVoteWeightSetting = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightInterestList>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVoteWeightSetting",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_VoteWeightInterestList);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightProportion> __Method_GetVoteWeightProportion = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightProportion>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVoteWeightProportion",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_Election_VoteWeightProportion);

    static readonly aelf::Method<global::AElf.Contracts.Election.VoteInformation, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetCalculateVoteWeight = new aelf::Method<global::AElf.Contracts.Election.VoteInformation, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetCalculateVoteWeight",
        __Marshaller_Election_VoteInformation,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> __Method_GetVoteWeightInterestController = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo>(
        aelf::MethodType.View,
        __ServiceName,
        "GetVoteWeightInterestController",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_AuthorityInfo);

    static readonly aelf::Method<global::AElf.Contracts.Election.GetMinerReplacementInformationInput, global::AElf.Contracts.Election.MinerReplacementInformation> __Method_GetMinerReplacementInformation = new aelf::Method<global::AElf.Contracts.Election.GetMinerReplacementInformationInput, global::AElf.Contracts.Election.MinerReplacementInformation>(
        aelf::MethodType.View,
        __ServiceName,
        "GetMinerReplacementInformation",
        __Marshaller_Election_GetMinerReplacementInformationInput,
        __Marshaller_Election_MinerReplacementInformation);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.Election.ElectionContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Contracts.Election.ElectionContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    public class ElectionContractStub : aelf::ContractStubBase
    {
      public aelf::IMethodStub<global::AElf.Contracts.Election.InitialElectionContractInput, global::Google.Protobuf.WellKnownTypes.Empty> InitialElectionContract
      {
        get { return __factory.Create(__Method_InitialElectionContract); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> RegisterElectionVotingEvent
      {
        get { return __factory.Create(__Method_RegisterElectionVotingEvent); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.TakeElectionSnapshotInput, global::Google.Protobuf.WellKnownTypes.Empty> TakeSnapshot
      {
        get { return __factory.Create(__Method_TakeSnapshot); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> AnnounceElection
      {
        get { return __factory.Create(__Method_AnnounceElection); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> QuitElection
      {
        get { return __factory.Create(__Method_QuitElection); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.VoteMinerInput, global::AElf.Types.Hash> Vote
      {
        get { return __factory.Create(__Method_Vote); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.ChangeVotingOptionInput, global::Google.Protobuf.WellKnownTypes.Empty> ChangeVotingOption
      {
        get { return __factory.Create(__Method_ChangeVotingOption); }
      }

      public aelf::IMethodStub<global::AElf.Types.Hash, global::Google.Protobuf.WellKnownTypes.Empty> Withdraw
      {
        get { return __factory.Create(__Method_Withdraw); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.UpdateCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty> UpdateCandidateInformation
      {
        get { return __factory.Create(__Method_UpdateCandidateInformation); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.UpdateMultipleCandidateInformationInput, global::Google.Protobuf.WellKnownTypes.Empty> UpdateMultipleCandidateInformation
      {
        get { return __factory.Create(__Method_UpdateMultipleCandidateInformation); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.UpdateMinersCountInput, global::Google.Protobuf.WellKnownTypes.Empty> UpdateMinersCount
      {
        get { return __factory.Create(__Method_UpdateMinersCount); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.SetTreasurySchemeIdsInput, global::Google.Protobuf.WellKnownTypes.Empty> SetTreasurySchemeIds
      {
        get { return __factory.Create(__Method_SetTreasurySchemeIds); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.VoteWeightInterestList, global::Google.Protobuf.WellKnownTypes.Empty> SetVoteWeightInterest
      {
        get { return __factory.Create(__Method_SetVoteWeightInterest); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.VoteWeightProportion, global::Google.Protobuf.WellKnownTypes.Empty> SetVoteWeightProportion
      {
        get { return __factory.Create(__Method_SetVoteWeightProportion); }
      }

      public aelf::IMethodStub<global::AuthorityInfo, global::Google.Protobuf.WellKnownTypes.Empty> ChangeVoteWeightInterestController
      {
        get { return __factory.Create(__Method_ChangeVoteWeightInterestController); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> GetCandidates
      {
        get { return __factory.Create(__Method_GetCandidates); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> GetVotedCandidates
      {
        get { return __factory.Create(__Method_GetVotedCandidates); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateInformation> GetCandidateInformation
      {
        get { return __factory.Create(__Method_GetCandidateInformation); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.PubkeyList> GetVictories
      {
        get { return __factory.Create(__Method_GetVictories); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.GetTermSnapshotInput, global::AElf.Contracts.Election.TermSnapshot> GetTermSnapshot
      {
        get { return __factory.Create(__Method_GetTermSnapshot); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int32Value> GetMinersCount
      {
        get { return __factory.Create(__Method_GetMinersCount); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.GetElectionResultInput, global::AElf.Contracts.Election.ElectionResult> GetElectionResult
      {
        get { return __factory.Create(__Method_GetElectionResult); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> GetElectorVote
      {
        get { return __factory.Create(__Method_GetElectorVote); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> GetElectorVoteWithRecords
      {
        get { return __factory.Create(__Method_GetElectorVoteWithRecords); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.ElectorVote> GetElectorVoteWithAllRecords
      {
        get { return __factory.Create(__Method_GetElectorVoteWithAllRecords); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> GetCandidateVote
      {
        get { return __factory.Create(__Method_GetCandidateVote); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> GetCandidateVoteWithRecords
      {
        get { return __factory.Create(__Method_GetCandidateVoteWithRecords); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.StringValue, global::AElf.Contracts.Election.CandidateVote> GetCandidateVoteWithAllRecords
      {
        get { return __factory.Create(__Method_GetCandidateVoteWithAllRecords); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> GetVotersCount
      {
        get { return __factory.Create(__Method_GetVotersCount); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> GetVotesAmount
      {
        get { return __factory.Create(__Method_GetVotesAmount); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.PageInformation, global::AElf.Contracts.Election.GetPageableCandidateInformationOutput> GetPageableCandidateInformation
      {
        get { return __factory.Create(__Method_GetPageableCandidateInformation); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Types.Hash> GetMinerElectionVotingItemId
      {
        get { return __factory.Create(__Method_GetMinerElectionVotingItemId); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.DataCenterRankingList> GetDataCenterRankingList
      {
        get { return __factory.Create(__Method_GetDataCenterRankingList); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightInterestList> GetVoteWeightSetting
      {
        get { return __factory.Create(__Method_GetVoteWeightSetting); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.Election.VoteWeightProportion> GetVoteWeightProportion
      {
        get { return __factory.Create(__Method_GetVoteWeightProportion); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.VoteInformation, global::Google.Protobuf.WellKnownTypes.Int64Value> GetCalculateVoteWeight
      {
        get { return __factory.Create(__Method_GetCalculateVoteWeight); }
      }

      public aelf::IMethodStub<global::Google.Protobuf.WellKnownTypes.Empty, global::AuthorityInfo> GetVoteWeightInterestController
      {
        get { return __factory.Create(__Method_GetVoteWeightInterestController); }
      }

      public aelf::IMethodStub<global::AElf.Contracts.Election.GetMinerReplacementInformationInput, global::AElf.Contracts.Election.MinerReplacementInformation> GetMinerReplacementInformation
      {
        get { return __factory.Create(__Method_GetMinerReplacementInformation); }
      }

    }
  }
}
#endregion

