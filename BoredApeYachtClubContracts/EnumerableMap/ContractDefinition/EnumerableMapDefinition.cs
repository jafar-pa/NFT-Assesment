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

namespace BoredApeYachtClubContracts.Contracts.EnumerableMap.ContractDefinition
{


    public partial class EnumerableMapDeployment : EnumerableMapDeploymentBase
    {
        public EnumerableMapDeployment() : base(BYTECODE) { }
        public EnumerableMapDeployment(string byteCode) : base(byteCode) { }
    }

    public class EnumerableMapDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212201a5e7e82f49db9cf2074adcad4678ef2e36491b6f3fb72d82792050077ea4c8d64736f6c63430007060033";
        public EnumerableMapDeploymentBase() : base(BYTECODE) { }
        public EnumerableMapDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
