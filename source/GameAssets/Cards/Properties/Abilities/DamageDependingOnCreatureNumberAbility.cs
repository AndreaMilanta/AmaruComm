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
        public int bonusDmg { get; private set; }
        public DamageDependingOnCreatureNumberAbility(int cost, int numTarget, int bonusDmg, Place myZone) : base(cost, numTarget)
        {
            this.myZone = myZone;
            this.bonusDmg = bonusDmg;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
