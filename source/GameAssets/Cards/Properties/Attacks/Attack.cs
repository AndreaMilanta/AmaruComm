using System;

using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public abstract class Attack : CardProperty
    {
        public int Cost { get; private set; }

        public Attack(int cost)
        {
            this.Cost = cost;
        }

        public abstract override int Visit(IPropertyVisitor visitor);
    }
}
