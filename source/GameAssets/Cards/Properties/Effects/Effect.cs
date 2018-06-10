using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Effects
{
    [Serializable]
    public abstract class Effect : CardProperty
    {
        public int Cost { get; private set; }

        protected Effect(int cost)
        {
            this.Cost = cost;
        }
    }
}
