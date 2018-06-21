using System;

using AmaruCommon.Actions;

namespace AmaruCommon.Actions
{
    public interface IActionVisitor
    {
        void Visit(AttackPlayerAction action);
        void Visit(MoveCreatureAction action);
        void Visit(PlayACreatureFromHandAction action);
        void Visit(PlayASpellFromHandAction action);
        void Visit(EndTurnAction endTurnAction);
        void Visit(AttackCreatureAction attackCreatureAction);
    }
}
