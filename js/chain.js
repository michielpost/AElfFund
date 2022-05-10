//const aelf = new AElf(new AElf.providers.HttpProvider('https://explorer-test-side01.aelf.io/chain'));
const nodeUrl = "https://explorer-test.aelf.io/chain";
//const nodeUrl = "https://explorer-test-side01.aelf.io/chain";
//const nodeUrl = "https://aelf-test-node.aelf.io/chain";

const tokenContractName = 'AElf.ContractNames.Token';
let tokenContractAddress;

let aelf;
let nightElfInstance = null;
let walletAddress = null;

class NightElfCheck {
    constructor() {
        const readyMessage = 'NightElf is ready';
        let resovleTemp = null;
        this.check = new Promise((resolve, reject) => {
            if (window.NightElf) {
                resolve(readyMessage);
            }
            setTimeout(() => {
                reject({
                    error: 200001,
                    message: 'timeout / can not find NightElf / please install the extension'
                });
            }, 1000);
            resovleTemp = resolve;
        });
        document.addEventListener('NightElf', result => {
            console.log('test.js check the status of extension named nightElf: ', result);
            resovleTemp(readyMessage);
        });
    }
    static getInstance() {
        if (!nightElfInstance) {
            nightElfInstance = new NightElfCheck();
            return nightElfInstance;
        }
        return nightElfInstance;
    }
}

const nightElfCheck = NightElfCheck.getInstance();
var message = await nightElfCheck.check;

// connectChain -> Login -> initContract -> call contract methods
console.log(message);

aelf = new window.NightElf.AElf({
    httpProvider: [
        nodeUrl,
    ],
    appName: 'aelf fund',
    // If you don't set pure=true, you will get old data structure which is not match aelf-sdk.js return.
    // v1.1.3  
    pure: true
});


window.GetBalance = async () => {
    const wallet1 = {
        address: walletAddress
    };

    var contractResult = await aelf.chain.contractAt(tokenContractAddress, wallet1);

    if (contractResult) {
        const payload1 = {
            symbol: 'ELF',
            owner: wallet1.address
        };

        var callResult = await contractResult.GetBalance.call(payload1);

        // If you use a framework like react, this process will become easier
        if (callResult) {
            return callResult;
        }
    }

    return null;
}

window.UseFaucet = async () => {
    const wallet1 = {
        address: walletAddress
    };

    var contractResult = await aelf.chain.contractAt("2M24EKAecggCnttZ9DUUMCXi4xC67rozA87kFgid9qEwRUMHTs", wallet1);

    if (contractResult) {
        const payload1 = {
            symbol: 'ELF',
            amount: "10000000000"
        };

        var callResult = await contractResult.Take(payload1);

        // If you use a framework like react, this process will become easier
        if (callResult) {
            return callResult.TransactionId;
        }
    }

    return null;
}

window.GetTxStatus = async (txId) => {
    var result = await aelf.chain.getTxResult(txId);
    return result;
};

window.HasNightElf = async () => {
    if (window.NightElf) {
        return true;
    }
    else {
        return false;
    }
};

window.IsConnected = async () => {
    if (window.NightElf && walletAddress) {
        return true;
    }
    else {
        return false;
    }
};

window.GetAddress = () => {
    return walletAddress;
};

window.Login = async () => {
    if (aelf) {
        let result = await aelf.login({
            chainId: "AELF",
            payload: {
                method: "LOGIN",
            },
        });

        console.log(result);
        walletAddress = JSON.parse(result.detail).address;

        const wallet1 = {
            address: walletAddress
        };

        // get chain status
        const chainStatus = await aelf.chain.getChainStatus();
        // get genesis contract address
        const GenesisContractAddress = chainStatus.GenesisContractAddress;
        // get genesis contract instance
        const zeroContract = await aelf.chain.contractAt(GenesisContractAddress, wallet1);
        // Get contract address by the read only method `GetContractAddressByName` of genesis contract
        tokenContractAddress = await zeroContract.GetContractAddressByName.call(AElf.utils.sha256(tokenContractName));

        return walletAddress;
    }

    return null;
};

window.Logout = async () => {
    walletAddress = null;
    if (aelf) {
        let result = await aelf.logout({
            chainId: "AELF",
            address: walletAddress,
        });

        console.log(result);
    }
};

window.Test = async () => {
    // get chain status
    const chainStatus = await aelf.chain.getChainStatus();
    console.log("ok:");
    console.log(chainStatus);
    // get genesis contract address
    // const GenesisContractAddress = chainStatus.GenesisContractAddress;
    // get genesis contract instance
    //const zeroContract = await aelf.chain.contractAt(GenesisContractAddress, newWallet);
    // Get contract address by the read only method `GetContractAddressByName` of genesis contract
    //tokenContractAddress = await zeroContract.GetContractAddressByName.call(AElf.utils.sha256(tokenContractName));
};

