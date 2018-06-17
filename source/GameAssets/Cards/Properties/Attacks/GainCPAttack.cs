using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards
{
    internal class GainCPAttack : Attack
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