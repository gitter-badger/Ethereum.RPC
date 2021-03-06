
using edjCase.JsonRpc.Client;
using System;
using Ethereum.RPC.Eth;

namespace Ethereum.RPC.Sample.Testers
{
    public class EthGasPriceTester : IRPCRequestTester
    {
        public dynamic ExecuteTest(RpcClient client)
        {
            var ethGasPrice = new EthGasPrice();
            return ethGasPrice.SendRequestAsync(client).Result;
        }

        public Type GetRequestType()
        {
            return typeof(EthGasPrice);
        }
    }
}
        