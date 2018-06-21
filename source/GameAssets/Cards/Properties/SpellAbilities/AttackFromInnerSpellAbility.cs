using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public class AttackFromInnerSpellAbility : SpellAbility
    {
        public int BonusAttack { get; private set; }

        protected AttackFromInnerSpellAbility(int bonusAttack) : base(false,0, Constants.KindOfTarget.NONE)
        {
            this.BonusAttack = bonusAttack;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
