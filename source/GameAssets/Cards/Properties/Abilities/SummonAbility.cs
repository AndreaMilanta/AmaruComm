using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class SummonAbility : Ability
    {
        public CreatureCard toSummon { get; private set; }

        public SummonAbility(int cost, int numTarget, CreatureCard toSummon ): base(cost, numTarget)
        {
            this.toSummon = toSummon;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
