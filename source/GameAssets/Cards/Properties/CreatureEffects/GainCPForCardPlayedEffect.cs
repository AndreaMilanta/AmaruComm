using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    public class GainCPForCardPlayed : CreatureEffect
    {
        public int buffNumber { get; private set; }

        protected GainCPForCardPlayed(int buffNumber = 1)
        {
            this.buffNumber = buffNumber;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}