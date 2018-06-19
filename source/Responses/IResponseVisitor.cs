using System;

namespace AmaruCommon.Responses
{
    public interface IResponseVisitor
    {
        void Visit(NewTurnResponse response);
        void Visit(MainTurnResponse mainTurnResponse);
    }
}
