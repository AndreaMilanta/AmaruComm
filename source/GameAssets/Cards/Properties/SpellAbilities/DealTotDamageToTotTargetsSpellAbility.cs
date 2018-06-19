using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties;

namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    class DealTotDamageToTotTargetsSpellAbility : SpellAbility
    {
        public int numTarget { get; private set; }
        public int DamageToDeal { get; private set; }

        public DealTotDamageToTotTargetsSpellAbility(int numTarget = 3, int damageToDeal = 3)
        {
            this.numTarget = numTarget;
            this.DamageToDeal = damageToDeal;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}