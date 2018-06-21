using System;
using System.Runtime.Serialization;

namespace AmaruServer.Game.Managing
{
    [Serializable]
    public class InvalidCardTypeException : Exception
    {
        public InvalidCardTypeException()
        {
        }
    }
}