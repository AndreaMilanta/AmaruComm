using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class DoubleHPAbility : Ability
    {

        public DoubleHPAbility(int cost, int numTarget) : base(cost, numTarget)
        {
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
