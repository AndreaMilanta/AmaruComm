using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class AttackPlayerAction : PlayerAction
    {
        public PlayerTarget Target { get; private set; }
        public Property PlayedProperty { get; private set; }

        public AttackPlayerAction(CharacterEnum caller, int playedCardId, Property playedProperty, PlayerTarget target) : base(caller, playedCardId)
        {
            this.Target = target;
            this.PlayedProperty = PlayedProperty;
        }

        public override void Visit(ActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
