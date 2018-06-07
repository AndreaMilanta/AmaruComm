using System;

using ClientServer.Messages;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class LoginMessage : Message
    {
        public string Username { get; private set; }

        public string Password { get; private set; }

        public LoginMessage(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
