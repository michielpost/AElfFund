using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.FundingContract
{
    public class FundingContractTestBase : DAppContractTestBase<FundingContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal FundingContractContainer.FundingContractStub GetFundingContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<FundingContractContainer.FundingContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}