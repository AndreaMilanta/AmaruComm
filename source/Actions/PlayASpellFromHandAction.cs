using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class PlayASpellFromHandAction : PlayerAction
    {
        public int Targets { get; private set; }

        public PlayASpellFromHandAction(CharacterEnum caller, int playedCardId, int targets) : base(caller, playedCardId)
        {
            this.Targets = targets;
        }

        public override void Visit(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
