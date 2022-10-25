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

namespace BoredApeYachtClubContracts.Contracts.Strings.ContractDefinition
{


    public partial class StringsDeployment : StringsDeploymentBase
    {
        public StringsDeployment() : base(BYTECODE) { }
        public StringsDeployment(string byteCode) : base(byteCode) { }
    }

    public class StringsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea264697066735822122090e13f64f133d0cb34b74a38d11daba1e111df66ae093db55bb1732c022be94464736f6c63430007060033";
        public StringsDeploymentBase() : base(BYTECODE) { }
        public StringsDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
