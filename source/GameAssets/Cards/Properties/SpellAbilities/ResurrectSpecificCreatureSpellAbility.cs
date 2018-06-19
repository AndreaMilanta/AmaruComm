using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public class ResurrectSpecificCreatureSpellAbility : SpellAbility
    {
        public Place myZone { get; private set; }
        public CreatureCard myTarget { get; private set; }
        protected ResurrectSpecificCreatureSpellAbility(Place myZone, CreatureCard myTarget) : base(true)
        {
            this.myTarget = myTarget;
            this.myZone = myZone;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}