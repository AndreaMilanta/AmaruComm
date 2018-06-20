using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class GainHPAttack : SimpleAttack
    {
        public int Hp { get; private set; }
        public bool ToCreature { get; private set; }
        public GainHPAttack(int cost, int power, int hp, bool toCreature) : base(cost, power)
        {
            this.Hp = hp;
            this.ToCreature = ToCreature;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}