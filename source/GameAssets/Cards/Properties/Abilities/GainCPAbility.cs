using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class GainCPAbility : Ability
    {
        public int cp { get; private set; }

        public GainCPAbility(int cost, int numTarget, int cp) : base (cost, numTarget)
        {
            this.cp = cp;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
