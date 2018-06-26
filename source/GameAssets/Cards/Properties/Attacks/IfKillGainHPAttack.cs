using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class IfKillGainHPAttack : SimpleAttack
    {
        public int BonusHP { get; private set; }
        public IfKillGainHPAttack(int cost, int power, int bonusHP) : base(cost, power)
        {
            this.BonusHP = bonusHP;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
