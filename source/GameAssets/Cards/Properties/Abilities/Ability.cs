using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public abstract class Ability : CardProperty
    {
        public int Cost { get; private set; }

        protected Ability(int cost)
        {
            this.Cost = cost;
        }

        public abstract override int Visit(IPropertyVisitor visitor);
    }
}
