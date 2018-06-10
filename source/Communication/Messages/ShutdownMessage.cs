using System;

using ClientServer.Messages;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class ShutdownMessage : Message
    {
        public int Id { get; private set; } = 0;
    }
}
