using System;
using System.Runtime.Serialization;

namespace AmaruCommon.Exceptions
{
    [Serializable]
    public class InvalidCardTypeException : Exception
    {
        public InvalidCardTypeException()
        {
        }
    }
}