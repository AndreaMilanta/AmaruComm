using System;
using System.Collections.Generic;
using AmaruCommon.GameAssets.Cards.Properties;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class DealDamageDependingOnMAXHPSpeelAbility : SpellAbility
    {
        protected DealDamageDependingOnMAXHPSpeelAbility() : base(true,1,Constants.KindOfTarget.MIXED)
        {
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}