using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace BoredApeYachtClubContracts.Contracts.EnumerableSet.ContractDefinition
{


    public partial class EnumerableSetDeployment : EnumerableSetDeploymentBase
    {
        public EnumerableSetDeployment() : base(BYTECODE) { }
        public EnumerableSetDeployment(string byteCode) : base(byteCode) { }
    }

    public class EnumerableSetDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea2646970667358221220274ad2b5c11881ad061cdc47b17cc127a53e363dd86ce078aa22a1fb51a7847d64736f6c63430007060033";
        public EnumerableSetDeploymentBase() : base(BYTECODE) { }
        public EnumerableSetDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
