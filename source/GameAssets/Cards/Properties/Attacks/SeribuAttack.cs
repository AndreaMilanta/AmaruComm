using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards
{
    internal class SeribuAttack : Attack
    {
        public SeribuAttack(int cost) : base(cost)
        {

        }

        public override void Visit(IPropertyVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}