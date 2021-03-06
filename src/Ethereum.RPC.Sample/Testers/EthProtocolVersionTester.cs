
using edjCase.JsonRpc.Client;
using System;
using Ethereum.RPC.Eth;

namespace Ethereum.RPC.Sample.Testers
{
    public class EthProtocolVersionTester : IRPCRequestTester
    {
        public dynamic ExecuteTest(RpcClient client)
        {
            var ethProtocolVersion = new EthProtocolVersion();
            return ethProtocolVersion.SendRequestAsync(client).Result;
        }

        public Type GetRequestType()
        {
            return typeof(EthProtocolVersion);
        }
    }
}
        