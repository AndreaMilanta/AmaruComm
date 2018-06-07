using System;

namespace AmaruCommon.Exceptions
{
    public class InvalidUserCredentialsException : Exception
    {
        private string _username = null;
        public InvalidUserCredentialsException(string user)
        {
            _username = user;
        }

        public override string ToString()
        {
            return "Failed access to log in as " + _username;
        }
    }
}
