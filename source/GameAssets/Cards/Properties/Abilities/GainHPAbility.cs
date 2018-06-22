using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class GainHPAbility : Ability
    {
        public int Hp { get; private set; }

        public GainHPAbility(int cost, int numTarget, int hp) : base(cost, numTarget)
        {
            this.Hp = hp;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
