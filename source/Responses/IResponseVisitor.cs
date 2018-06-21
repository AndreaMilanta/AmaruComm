using System;

namespace AmaruCommon.Responses
{
    public interface IResponseVisitor
    {
        void Visit(NewTurnResponse response);
        void Visit(MainTurnResponse mainTurnResponse);
        void Visit(PlayACreatureResponse playACreatureResponse);
        void Visit(PlayASpellResponse playASpellResponse);
        void Visit(MoveCreatureResponse moveCreatureResponse);
        void Visit(AttackCreatureResponse attackCreatureResponse);
        void Visit(AttackPlayerResponse attackPlayerResponse);
    }
}
