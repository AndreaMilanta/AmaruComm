using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    class DamagePDToAllCreaturesOfTargetPlayerSpellAbility : SpellAbility
    {
        public int numPd { get; private set; }
        public DamagePDToAllCreaturesOfTargetPlayerSpellAbility(int numPd =1)
        {
            this.numPd = numPd;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
