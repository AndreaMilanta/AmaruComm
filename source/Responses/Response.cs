using System;

namespace AmaruCommon.Responses
{
    public abstract class Response
    {
        public abstract void Visit(IResponseVisitor visitor);
    }
}
