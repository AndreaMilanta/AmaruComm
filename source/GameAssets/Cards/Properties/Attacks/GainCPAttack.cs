using System;

using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class GainCPAttack : SimpleAttack
    {
        public int Cp { get; private set; }

        public GainCPAttack(int cost, int power, int cp) : base(cost, power)
        {
            this.Cp = cp;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}