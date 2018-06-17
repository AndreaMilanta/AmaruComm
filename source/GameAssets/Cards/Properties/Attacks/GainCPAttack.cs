using System;

using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class GainCPAttack : Attack
    {
        public int Cp { get; private set; }

        public GainCPAttack(int cost, int cp) : base(cost)
        {
            this.Cp = cp;
        }

        public override void Visit(IPropertyVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}