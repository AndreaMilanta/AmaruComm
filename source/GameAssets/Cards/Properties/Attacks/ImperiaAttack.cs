using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class ImperiaAttack : Attack
    {

        public ImperiaAttack(int cost) : base(cost)
        {
 
        }

        public override void Visit(IPropertyVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}