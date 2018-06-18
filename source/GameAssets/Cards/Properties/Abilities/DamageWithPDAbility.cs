using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class DamageWithPDAbility : Ability
    {
        public int numTarget { get; private set; }
        public int numPD { get; private set; }
        protected DamageWithPDAbility(int cost, int numTarget, int numPD) : base(cost)
        {
            this.numTarget = numTarget;
            this.numPD = numPD;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
