using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class PoisonAttack : Attack
    {
        public int Power { get; private set; }

        public PoisonAttack(int cost, int power) : base(cost)
        {
            this.Power = power;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
