using System;
using System.Runtime.Serialization;

namespace AmaruCommon.Exceptions
{
    [Serializable]
    public class InvalidTargetException : Exception
    {
        public InvalidTargetException()
        {
        }

    }
}