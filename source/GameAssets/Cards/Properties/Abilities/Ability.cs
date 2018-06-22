using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public abstract class Ability : CardProperty
    {
        public int Cost { get; private set; }
        public int NumTarget { get; private set; }
        protected Ability(int cost, int numTarget)
        {
            this.Cost = cost;
            this.NumTarget = numTarget;
        }

        public abstract override int Visit(PropertyVisitor visitor);
    }
}
