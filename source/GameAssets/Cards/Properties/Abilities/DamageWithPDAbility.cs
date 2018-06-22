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
        public int NumPD { get; private set; }

        protected DamageWithPDAbility(int cost, int numTarget, int numPD) : base(cost, numTarget)
        {
            this.NumPD = numPD;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
