using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    class GainCpSpellAbility : SpellAbility
    {
        public int numCP { get; private set; }
        public GainCpSpellAbility (int numCP = 4)
        {
            this.numCP = numCP;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}