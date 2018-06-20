using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class AmaruIncarnationAbility : Ability
    {
        protected AmaruIncarnationAbility(int cost) : base(cost)
        {
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
