using System;


namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public abstract class Attack : CardProperty
    {
        public int Cost { get; private set; }
        public int BonusAttack { get; set; } = 0;

        public Attack(int cost)
        {
            this.Cost = cost;
        }

        public abstract override int Visit(PropertyVisitor visitor);
    }
}
