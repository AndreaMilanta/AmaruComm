using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class AttackCreatureAction : PlayerAction
    {
        public CardTarget Target { get; private set; }
        public Property PlayedProperty { get; private set; }

        public AttackCreatureAction(CharacterEnum caller, int playedCardId, Property playedProperty, CardTarget target) : base(caller, playedCardId)
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
