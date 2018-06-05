using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using ClientServer.Communication;
using ClientServer.Messages;

namespace AmaruCommon.Client
{
    public class Client : ClientTCP
    {
        public Client(Socket soc, int bufferSize, string log) : base(soc, bufferSize, log)
        {
        }

        protected override void HandleNewMessage(Message mex)
        {
            throw new NotImplementedException();
        }
    }
}
