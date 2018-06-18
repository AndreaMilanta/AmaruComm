using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class GainHPAttack : Attack
    {
        public int Power { get; private set; }
        public int Hp { get; private set; }
        public bool ToCreature { get; private set; }
        public GainHPAttack(int cost, int power, int hp, bool toCreature) : base(cost)
        {
            this.Power = power;
            this.Hp = hp;
            this.ToCreature = ToCreature;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}