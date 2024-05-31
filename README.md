# GamingwithBabyDoge

![Screenshot 2024-06-09 044108.png](https://cdn.dorahacks.io/static/files/18ffa54e1d1155bf0b7e13c40c6befbd.png)

Welcome to **GamingwithBabyDoge**! Immerse yourself in a thrilling role-playing adventure built with BabyDoge in Unity on the BNB Chain. This unique game allows BabyDoge owners to take their BabyDoge characters into the game and solve hidden quests, blending the excitement of gaming with the innovative power of blockchain technology.

## Features

### 🗡️ Complete Quests and Earn BabyDogeQuestCoin (BDQC) Coins 💰

Embark on thrilling quests filled with challenges, puzzles, and adventures. Each successfully completed quest will reward you with valuable BabyDogeQuestCoin (BDQC) coins. These coins serve as your ticket to unlocking the next level of excitement in our game.

BabyDogeQuestCoin Contract: https://testnet.bscscan.com/address/0x9B8C7E9cC11C3005857aCd9cd6fEFD4068E46ADD

Visit the above link to explore the BabyDogeQuestCoin (BDQC) contract on the BSC Blockchain. It ensures a secure and transparent environment for your in-game transactions. Earn, trade, and utilize your hard-earned coins to enhance your gaming experience.

### ⚔️ Collect Beautiful Ability NFTs from Marketplace 💎

Show off your achievements and upgrade your arsenal by collecting and upgrading your BabyDoge abilities with Ability NFTs from the Marketplace. These unique and valuable Non-Fungible Tokens represent powerful abilities that can aid you in your quests and elevate your BabyDoge to a formidable player.

### 🛒 Dynamic In-Game Economy

Visit the Marketplace to unleash the full potential of your coins. Here, you can buy, sell, and trade Ability NFTs with other players, creating a vibrant and dynamic in-game economy. Find the perfect abilities to suit your playstyle and make your mark in the gaming community.

### 🔄 Token Integration with BabyDogeSwap

With our platform token, we also have a sweet integration with BabyDogeSwap for swapping any token on the BSC to our platform token. This seamless integration allows for efficient and flexible trading within the game.

- Smart Contract Function that we are utilsing for this

- Token Swap Function

```solidity
function swapTokensForExactTokens(
  uint amountOut,
  uint amountInMax,
  address[] calldata path,
  address to,
  uint deadline
) external returns (uint[] memory amounts);
```

- **amountOut**: The exact amount of output tokens.
- **amountInMax**: The maximum amount of input tokens.
- **path**: An array of token addresses. Pools for each consecutive pair of addresses must exist and have liquidity.
- **to**: Address of the recipient.
- **deadline**: Unix timestamp deadline by which the transaction must confirm.

## Getting Started

### Prerequisites

- Unity 3D
- MetaMask or any Web3 wallet
- BabyDoge tokens
- Basic understanding of blockchain and NFTs

### Installation

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/YourUsername/GamingwithBabyDoge.git
   cd GamingwithBabyDoge
   ```

1. **Open in Unity:**
   Open the cloned repository in Unity Hub and open the project.

1. **Install Dependencies:**
   Ensure all necessary packages and dependencies are installed through Unity's package manager.

1. **Connect Wallet:**
   Connect your MetaMask wallet to the BNB Chain and ensure you have BabyDoge tokens.

1. **Run the Game:**
   Press the Play button in Unity to start the game and begin your adventure with BabyDoge.

## Contributing

We welcome contributions from the community! Feel free to fork the repository, create a new branch, and submit a pull request with your improvements or new features.


Enjoy your adventure in the world of GamingwithBabyDoge!