﻿//const aelf = new AElf(new AElf.providers.HttpProvider('https://explorer-test-side01.aelf.io/chain'));
//const tokenContractName = 'AElf.ContractNames.Token';

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
nightElfCheck.check.then(message => {
    // connectChain -> Login -> initContract -> call contract methods
    console.log(message);

    aelf = new window.NightElf.AElf({
        httpProvider: [
            'https://explorer-test-side01.aelf.io/chain',
        ],
        appName: 'aelf fund',
        // If you don't set pure=true, you will get old data structure which is not match aelf-sdk.js return.
        // v1.1.3  
        pure: true
    });

});

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
