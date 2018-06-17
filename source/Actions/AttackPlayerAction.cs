using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    public class AttackPlayerAction : PlayerAction
    {
        public PlayerTarget Target { get; private set; }

        public AttackPlayerAction(CharacterEnum caller, int playedCardId, Property playedProperty, PlayerTarget target) : base(caller, playedCardId, playedProperty)
        {
            this.Target = target;
        }

        public override void Visit(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
