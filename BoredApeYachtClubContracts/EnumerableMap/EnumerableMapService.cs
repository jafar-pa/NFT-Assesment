using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using BoredApeYachtClubContracts.Contracts.EnumerableMap.ContractDefinition;

namespace BoredApeYachtClubContracts.Contracts.EnumerableMap
{
    public partial class EnumerableMapService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, EnumerableMapDeployment enumerableMapDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<EnumerableMapDeployment>().SendRequestAndWaitForReceiptAsync(enumerableMapDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, EnumerableMapDeployment enumerableMapDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<EnumerableMapDeployment>().SendRequestAsync(enumerableMapDeployment);
        }

        public static async Task<EnumerableMapService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, EnumerableMapDeployment enumerableMapDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, enumerableMapDeployment, cancellationTokenSource);
            return new EnumerableMapService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public EnumerableMapService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
