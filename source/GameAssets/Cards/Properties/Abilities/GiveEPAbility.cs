using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class GiveEPAbility : Ability
    {
        public int Ep { get; private set; }
    
        protected GiveEPAbility(int cost, int numTarget, int ep) : base(cost, numTarget)
        {
            this.Ep = ep;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
