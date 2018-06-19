using System;
using System.Collections.Generic;
using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    class DealDamageDependingOnMAXHPSpeelAbility : SpellAbility
    {
        public DealDamageDependingOnMAXHPSpeelAbility()
        {
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}