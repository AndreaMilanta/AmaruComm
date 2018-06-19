using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    class DealDamageToEverythingSpellAbility : SpellAbility
    {
        public int numDamage { get; private set; }
        public DealDamageToEverythingSpellAbility(int numDamage = 3)
        {
            this.numDamage= numDamage;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}