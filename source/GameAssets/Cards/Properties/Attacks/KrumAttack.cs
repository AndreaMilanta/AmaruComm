using System;

using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class KrumAttack : Attack
    {
        public KrumAttack(int cost) : base(cost)
        {
        }

        public override void Visit(IPropertyVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}