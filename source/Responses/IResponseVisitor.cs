using System;

using AmaruCommon.Responses;

namespace AmaruCommon.Responses
{
    public interface IResponseVisitor
    {
        void Visit(NewTurnResponse response);
    }
}
