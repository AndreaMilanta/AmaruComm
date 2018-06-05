using System.Net.Sockets;

using ClientServer.Communication;
using ClientServer.Messages;
using AmaruCommon.Messages;

namespace AmaruCommon.Client
{
    public class Client : ClientTCP
    {
        public Client(Socket soc, int bufferSize, string log) : base(soc, bufferSize, log)
        {
        }

        protected override void HandleNewMessage(Message mex)
        {
            if (!(mex is AmaruMessage))

            if (mex is LoginMessage)
        }
    }
}
