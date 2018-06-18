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

        protected SummonAbility(int cost, CreatureCard toSummon ): base(cost)
        {
            this.toSummon = toSummon;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
