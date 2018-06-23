using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    [Serializable]
    public class GainCPForCardPlayedEffect : CreatureEffect
    {
        public int buffNumber { get; private set; }

        public GainCPForCardPlayedEffect(int buffNumber = 1)
        {
            this.buffNumber = buffNumber;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}