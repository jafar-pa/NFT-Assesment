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
using BoredApeYachtClubContracts.Contracts.BoredApeYachtClub.ContractDefinition;

namespace BoredApeYachtClubContracts.Contracts.BoredApeYachtClub
{
    public partial class BoredApeYachtClubService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, BoredApeYachtClubDeployment boredApeYachtClubDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BoredApeYachtClubDeployment>().SendRequestAndWaitForReceiptAsync(boredApeYachtClubDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, BoredApeYachtClubDeployment boredApeYachtClubDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BoredApeYachtClubDeployment>().SendRequestAsync(boredApeYachtClubDeployment);
        }

        public static async Task<BoredApeYachtClubService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, BoredApeYachtClubDeployment boredApeYachtClubDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, boredApeYachtClubDeployment, cancellationTokenSource);
            return new BoredApeYachtClubService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public BoredApeYachtClubService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> BAYC_PROVENANCEQueryAsync(BAYC_PROVENANCEFunction bAYC_PROVENANCEFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BAYC_PROVENANCEFunction, string>(bAYC_PROVENANCEFunction, blockParameter);
        }

        
        public Task<string> BAYC_PROVENANCEQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BAYC_PROVENANCEFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> MAX_APESQueryAsync(MAX_APESFunction mAX_APESFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_APESFunction, BigInteger>(mAX_APESFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_APESQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_APESFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> REVEAL_TIMESTAMPQueryAsync(REVEAL_TIMESTAMPFunction rEVEAL_TIMESTAMPFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<REVEAL_TIMESTAMPFunction, BigInteger>(rEVEAL_TIMESTAMPFunction, blockParameter);
        }

        
        public Task<BigInteger> REVEAL_TIMESTAMPQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<REVEAL_TIMESTAMPFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> ApePriceQueryAsync(ApePriceFunction apePriceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ApePriceFunction, BigInteger>(apePriceFunction, blockParameter);
        }

        
        public Task<BigInteger> ApePriceQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ApePriceFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public Task<string> BaseURIQueryAsync(BaseURIFunction baseURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseURIFunction, string>(baseURIFunction, blockParameter);
        }

        
        public Task<string> BaseURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseURIFunction, string>(null, blockParameter);
        }

        public Task<string> EmergencySetStartingIndexBlockRequestAsync(EmergencySetStartingIndexBlockFunction emergencySetStartingIndexBlockFunction)
        {
             return ContractHandler.SendRequestAsync(emergencySetStartingIndexBlockFunction);
        }

        public Task<string> EmergencySetStartingIndexBlockRequestAsync()
        {
             return ContractHandler.SendRequestAsync<EmergencySetStartingIndexBlockFunction>();
        }

        public Task<TransactionReceipt> EmergencySetStartingIndexBlockRequestAndWaitForReceiptAsync(EmergencySetStartingIndexBlockFunction emergencySetStartingIndexBlockFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(emergencySetStartingIndexBlockFunction, cancellationToken);
        }

        public Task<TransactionReceipt> EmergencySetStartingIndexBlockRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<EmergencySetStartingIndexBlockFunction>(null, cancellationToken);
        }

        public Task<string> FlipSaleStateRequestAsync(FlipSaleStateFunction flipSaleStateFunction)
        {
             return ContractHandler.SendRequestAsync(flipSaleStateFunction);
        }

        public Task<string> FlipSaleStateRequestAsync()
        {
             return ContractHandler.SendRequestAsync<FlipSaleStateFunction>();
        }

        public Task<TransactionReceipt> FlipSaleStateRequestAndWaitForReceiptAsync(FlipSaleStateFunction flipSaleStateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(flipSaleStateFunction, cancellationToken);
        }

        public Task<TransactionReceipt> FlipSaleStateRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<FlipSaleStateFunction>(null, cancellationToken);
        }

        public Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        
        public Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        public Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        
        public Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
                isApprovedForAllFunction.Operator = @operator;
            
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        public Task<BigInteger> MaxApePurchaseQueryAsync(MaxApePurchaseFunction maxApePurchaseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxApePurchaseFunction, BigInteger>(maxApePurchaseFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxApePurchaseQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxApePurchaseFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> MintApeRequestAsync(MintApeFunction mintApeFunction)
        {
             return ContractHandler.SendRequestAsync(mintApeFunction);
        }

        public Task<TransactionReceipt> MintApeRequestAndWaitForReceiptAsync(MintApeFunction mintApeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintApeFunction, cancellationToken);
        }

        public Task<string> MintApeRequestAsync(BigInteger numberOfTokens)
        {
            var mintApeFunction = new MintApeFunction();
                mintApeFunction.NumberOfTokens = numberOfTokens;
            
             return ContractHandler.SendRequestAsync(mintApeFunction);
        }

        public Task<TransactionReceipt> MintApeRequestAndWaitForReceiptAsync(BigInteger numberOfTokens, CancellationTokenSource cancellationToken = null)
        {
            var mintApeFunction = new MintApeFunction();
                mintApeFunction.NumberOfTokens = numberOfTokens;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintApeFunction, cancellationToken);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        
        public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> ReserveApesRequestAsync(ReserveApesFunction reserveApesFunction)
        {
             return ContractHandler.SendRequestAsync(reserveApesFunction);
        }

        public Task<string> ReserveApesRequestAsync()
        {
             return ContractHandler.SendRequestAsync<ReserveApesFunction>();
        }

        public Task<TransactionReceipt> ReserveApesRequestAndWaitForReceiptAsync(ReserveApesFunction reserveApesFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reserveApesFunction, cancellationToken);
        }

        public Task<TransactionReceipt> ReserveApesRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<ReserveApesFunction>(null, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function)
        {
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public Task<bool> SaleIsActiveQueryAsync(SaleIsActiveFunction saleIsActiveFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SaleIsActiveFunction, bool>(saleIsActiveFunction, blockParameter);
        }

        
        public Task<bool> SaleIsActiveQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SaleIsActiveFunction, bool>(null, blockParameter);
        }

        public Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
        {
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<string> SetBaseURIRequestAsync(SetBaseURIFunction setBaseURIFunction)
        {
             return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(SetBaseURIFunction setBaseURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public Task<string> SetBaseURIRequestAsync(string baseURI)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.BaseURI = baseURI;
            
             return ContractHandler.SendRequestAsync(setBaseURIFunction);
        }

        public Task<TransactionReceipt> SetBaseURIRequestAndWaitForReceiptAsync(string baseURI, CancellationTokenSource cancellationToken = null)
        {
            var setBaseURIFunction = new SetBaseURIFunction();
                setBaseURIFunction.BaseURI = baseURI;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseURIFunction, cancellationToken);
        }

        public Task<string> SetProvenanceHashRequestAsync(SetProvenanceHashFunction setProvenanceHashFunction)
        {
             return ContractHandler.SendRequestAsync(setProvenanceHashFunction);
        }

        public Task<TransactionReceipt> SetProvenanceHashRequestAndWaitForReceiptAsync(SetProvenanceHashFunction setProvenanceHashFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setProvenanceHashFunction, cancellationToken);
        }

        public Task<string> SetProvenanceHashRequestAsync(string provenanceHash)
        {
            var setProvenanceHashFunction = new SetProvenanceHashFunction();
                setProvenanceHashFunction.ProvenanceHash = provenanceHash;
            
             return ContractHandler.SendRequestAsync(setProvenanceHashFunction);
        }

        public Task<TransactionReceipt> SetProvenanceHashRequestAndWaitForReceiptAsync(string provenanceHash, CancellationTokenSource cancellationToken = null)
        {
            var setProvenanceHashFunction = new SetProvenanceHashFunction();
                setProvenanceHashFunction.ProvenanceHash = provenanceHash;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setProvenanceHashFunction, cancellationToken);
        }

        public Task<string> SetRevealTimestampRequestAsync(SetRevealTimestampFunction setRevealTimestampFunction)
        {
             return ContractHandler.SendRequestAsync(setRevealTimestampFunction);
        }

        public Task<TransactionReceipt> SetRevealTimestampRequestAndWaitForReceiptAsync(SetRevealTimestampFunction setRevealTimestampFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRevealTimestampFunction, cancellationToken);
        }

        public Task<string> SetRevealTimestampRequestAsync(BigInteger revealTimeStamp)
        {
            var setRevealTimestampFunction = new SetRevealTimestampFunction();
                setRevealTimestampFunction.RevealTimeStamp = revealTimeStamp;
            
             return ContractHandler.SendRequestAsync(setRevealTimestampFunction);
        }

        public Task<TransactionReceipt> SetRevealTimestampRequestAndWaitForReceiptAsync(BigInteger revealTimeStamp, CancellationTokenSource cancellationToken = null)
        {
            var setRevealTimestampFunction = new SetRevealTimestampFunction();
                setRevealTimestampFunction.RevealTimeStamp = revealTimeStamp;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRevealTimestampFunction, cancellationToken);
        }

        public Task<string> SetStartingIndexRequestAsync(SetStartingIndexFunction setStartingIndexFunction)
        {
             return ContractHandler.SendRequestAsync(setStartingIndexFunction);
        }

        public Task<string> SetStartingIndexRequestAsync()
        {
             return ContractHandler.SendRequestAsync<SetStartingIndexFunction>();
        }

        public Task<TransactionReceipt> SetStartingIndexRequestAndWaitForReceiptAsync(SetStartingIndexFunction setStartingIndexFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStartingIndexFunction, cancellationToken);
        }

        public Task<TransactionReceipt> SetStartingIndexRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<SetStartingIndexFunction>(null, cancellationToken);
        }

        public Task<BigInteger> StartingIndexQueryAsync(StartingIndexFunction startingIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartingIndexFunction, BigInteger>(startingIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> StartingIndexQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartingIndexFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> StartingIndexBlockQueryAsync(StartingIndexBlockFunction startingIndexBlockFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartingIndexBlockFunction, BigInteger>(startingIndexBlockFunction, blockParameter);
        }

        
        public Task<BigInteger> StartingIndexBlockQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StartingIndexBlockFunction, BigInteger>(null, blockParameter);
        }

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        
        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenByIndexFunction = new TokenByIndexFunction();
                tokenByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.Owner = owner;
                tokenOfOwnerByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        
        public Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<string> WithdrawRequestAsync()
        {
             return ContractHandler.SendRequestAsync<WithdrawFunction>();
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<WithdrawFunction>(null, cancellationToken);
        }
    }
}
