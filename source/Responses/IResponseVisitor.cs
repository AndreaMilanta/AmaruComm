using System;

namespace AmaruCommon.Responses
{
    public interface IResponseVisitor
    {
        void Visit(NewTurnResponse response);
    }
}
