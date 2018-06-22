using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class KillIfPDAbility : Ability
    {
        public int PDRequired { get; private set; }
        protected KillIfPDAbility(int cost, int numTarget, int PDRequired) : base(cost,numTarget)
        {
            this.PDRequired = PDRequired;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
