using System;

namespace AmaruCommon.Responses
{
    [Serializable]
    public abstract class Response
    {
        public abstract void Visit(IResponseVisitor visitor);
    }
}
