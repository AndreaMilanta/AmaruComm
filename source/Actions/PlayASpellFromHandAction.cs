using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;
using System.Collections.Generic;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class PlayASpellFromHandAction : PlayerAction
    {
        public List<Target> Targets { get; private set; }

        public PlayASpellFromHandAction(CharacterEnum caller, int playedCardId, List<Target> targets) : base(caller, playedCardId)
        {
            this.Targets = targets;
        }

        public override void Visit(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
