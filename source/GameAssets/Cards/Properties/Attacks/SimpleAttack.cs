using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class SimpleAttack : Attack
    {
        private int _power = 0;
        public int Power { get { return _power + BonusAttack; } }

        public SimpleAttack(int cost, int power) : base(cost)
        {
            this._power = power;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
