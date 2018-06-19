using System;

using AmaruCommon.Actions;

namespace AmaruCommon.Actions
{
    public interface IActionVisitor
    {
        void Visit(AttackPlayerAction action);
        void Visit(MoveCreatureAction action);
    }
}
