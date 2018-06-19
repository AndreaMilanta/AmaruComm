using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    class GiveHPSpellAbility : SpellAbility
    {
        public int numHP { get; private set; }
        public GiveHPSpellAbility(int numHP = 4)
        {
            this.numHP = numHP;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}