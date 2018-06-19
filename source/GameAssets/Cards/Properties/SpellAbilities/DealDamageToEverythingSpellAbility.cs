using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class DealDamageToEverythingSpellAbility : SpellAbility
    {
        public int numDamage { get; private set; }
        protected DealDamageToEverythingSpellAbility(int numDamage = 3) : base(true)
        {
            this.numDamage= numDamage;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}