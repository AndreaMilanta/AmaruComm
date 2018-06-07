using System;

using ClientServer.Messages;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class LoginReplyMessage : Message
    {
        public int Ranking { get; private set; } = 0;
        public int Points { get; private set; } = 0;
        public bool Success { get; private set; }

        public LoginReplyMessage(bool success, int ranking, int points)
        {
            this.Ranking = ranking;
            this.Points = points;
            this.Success = success;
        }

        public LoginReplyMessage(bool success)
        {
            this.Success = success;
        }
    }
}
