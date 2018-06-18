using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class DamageDependingOnCreatureNumberAbility : Ability
    {
        //This Ability is viable for both Wild Horse and Blooborne Rhino

        public Place myZone { get; private set; }
        public int myBonusDamage { get; private set; }
        protected DamageDependingOnCreatureNumberAbility(int cost, int bonusDamage, Place myZone) : base(cost)
        {
            this.myBonusDamage = bonusDamage;
            this.myZone = myZone;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
