using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    [Serializable]
    public class AttackBuffInSpecificZoneEffect : CreatureEffect
    {
        public int buffNumber { get; private set; }
        public Place myZone { get; private set; }
   
        protected AttackBuffInSpecificZoneEffect (int buffNumber = 1, Place myZone = Place.OUTER)
        {
            this.buffNumber = buffNumber;
            this.myZone = myZone;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}