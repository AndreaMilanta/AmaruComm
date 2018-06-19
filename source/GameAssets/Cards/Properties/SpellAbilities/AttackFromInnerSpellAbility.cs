using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    public class AttackFromInnerSpellAbility : SpellAbility
    {
        public int BonusAttack { get; private set; }

        protected AttackFromInnerSpellAbility(int bonusAttack)
        {
            this.BonusAttack = bonusAttack;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
