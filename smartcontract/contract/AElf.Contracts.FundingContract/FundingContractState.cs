using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.FundingContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class FundingContractState : ContractState
    {
        public SingletonState<ProjectList> ProjectList { get; set; }
        public SingletonState<FunderList> FunderList { get; set; }
    }
}