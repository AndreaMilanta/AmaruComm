using System;
using System.Runtime.Serialization;

namespace AmaruServer.Game.Managing
{
    [Serializable]
    public class InvalidTargetException : Exception
    {
        public InvalidTargetException()
        {
        }

    }
}