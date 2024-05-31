using System.Threading.Tasks;
using Thirdweb;
using UnityEngine;

namespace RPGM.Core
{
    public class Web3 : MonoBehaviour
    {
        // Instantiate the SDK with Gasless Transactions using OZ Defender
        private ThirdwebSDK
            sdk =
                new ThirdwebSDK("https://bsc-testnet-rpc.publicnode.com",
                    new ThirdwebSDK.Options()
                    {
                        gasless =
                            new ThirdwebSDK.GaslessOptions()
                            {
                                openzeppelin =
                                    new ThirdwebSDK.OZDefenderOptions()
                                    {
                                        relayerUrl =
                                        "https://api.defender.openzeppelin.com/actions/885dcdae-9622-4ad3-9e43-bb288871e6eb/runs/webhook/057dae42-4bf8-495b-a983-a6913f3e5f8b/DitqhpkxpEMUqyEg1t41qr"
                                    }
                            }
                    });

        public async Task<bool> IsConnected()
        {
            return await sdk.wallet.IsConnected();
        }

        public async Task<string> Connect()
        {
            string addr =
                await sdk
                    .wallet
                    .Connect(new WalletConnection()
                    {
                        provider = WalletProvider.MetaMask,
                        chainId = 97
                    });
            return addr;
        }

        public Contract GetTokenDropContract()
        {
            return sdk.GetContract("0x9B8C7E9cC11C3005857aCd9cd6fEFD4068E46ADD");
        }

        public async Task<TransactionResult> Claim()
        {
            await Connect();
            var contract = GetTokenDropContract();
            return await contract.ERC20.Claim("100");
        }

        public Marketplace GetMarketplaceContract()
        {
            return sdk
                .GetContract("0xC8088B0Bd559CA7535b480E47bc7Dc9B79Fe9084")
                .marketplace;
        }

        public async Task<TransactionResult> BuyItem(string itemId)
        {
            await Connect();
            return await GetMarketplaceContract().BuyListing(itemId, 1);
        }

        internal async Task<string> GetAddress()
        {
            if (Application.isEditor)
            {
                return "0x0000000000000000000000000000000000000000";
            }
            return await sdk.wallet.GetAddress();
        }
    }
}
