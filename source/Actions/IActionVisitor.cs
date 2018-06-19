using System;

using AmaruCommon.Actions;

namespace AmaruCommon.Actions
{
    public interface IActionVisitor
    {
        void Visit(AttackPlayerAction action);
        void Visit(PlayACreatureFromHandAction action);
        void Visit(PlayASpellFromHandAction playASpellFromHandAction);
    }
}
