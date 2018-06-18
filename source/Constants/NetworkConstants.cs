using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Constants
{
    public static class NetworkConstants
    {
        //IPv4 Credentials
        public const string ServerIp = "127.0.0.1";     // Main Server IP Address
        public const int ServerPort = 5555;             // Main Server Port

        //Data Transfer
        public const int BufferSize = 4096*4;             // Network Receiving Buffer size
        
        //Failure Detection
        public const int MaxFailures = 1000;          // Maximum number of failures to consider a client alive
        public const int MaxConsecutiveFailures = 10;   // Maximum number of consecutive failures to considere a client alive
    }
}
