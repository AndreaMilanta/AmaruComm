using System;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    [Serializable]
    public class Attack : CardProperty
    {
        public int Power { get; private set; }
        public int Cost { get; private set; }
        protected Attack(int cost, int power)
        {
            this.Power = power;
            this.Cost = cost;
        }
    }
}
