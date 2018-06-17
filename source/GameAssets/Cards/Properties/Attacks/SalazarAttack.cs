using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    public class SalazarAttack : Attack
    {
        public int Power { get; private set; }

        public SalazarAttack(int cost) : base(cost)
        {

        }

        public override void Visit(IPropertyVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
