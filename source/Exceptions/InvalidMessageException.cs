using System;

namespace AmaruCommon.Exceptions
{
    public class InvalidMessageException : Exception
    {
        public override string ToString()
        {
            return "Invalid Message receivd";
        }
    }
}
