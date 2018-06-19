using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    public class GainAdditionalEPEffect : CreatureEffect
    {
        public int EPNumber { get; private set; }


        protected GainAdditionalEPEffect(int epNumber = 1, Place myZone = Place.OUTER)
        {
            this.EPNumber = epNumber;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}