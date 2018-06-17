using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public abstract class GainHPAbility : CardProperty
    {
        public int Cost { get; private set; }
        public int Hp { get; private set; }

        protected GainHPAbility(int cost, int hp)
        {
            this.Cost = cost;
            this.Hp = hp;
        }
    }
}
