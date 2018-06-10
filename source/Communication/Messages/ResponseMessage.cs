using System;

using ClientServer.Messages;
using AmaruCommon.Responses;

namespace AmaruCommon.Communication.Messages
{
    public class ResponseMessage : Message
    {
        public Response Response { get; private set; }

        public ResponseMessage(Response response)
        {
            this.Response = response;
        }
    }
}
