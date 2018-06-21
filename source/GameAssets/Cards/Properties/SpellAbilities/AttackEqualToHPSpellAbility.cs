using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{ 

    [Serializable]
    public class AttackEqualToHPSpellAbility : SpellAbility
    {

        protected AttackEqualToHPSpellAbility(int numTarget = 1) : base (false,numTarget, Constants.KindOfTarget.CREATURE)
        {
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}