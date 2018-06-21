using System;

using AmaruCommon.Actions;
using Logging;

namespace AmaruCommon.Actions
{
    public abstract class ActionVisitor : Loggable
    {
        protected ActionVisitor (string logger) : base (logger) { }
        public abstract void Visit(AttackPlayerAction action);
        public abstract void Visit(MoveCreatureAction action);
        public abstract void Visit(PlayACreatureFromHandAction action);
        public abstract void Visit(PlayASpellFromHandAction action);
        public abstract void Visit(EndTurnAction action);
        public abstract void Visit(AttackCreatureAction action);
    }
}
