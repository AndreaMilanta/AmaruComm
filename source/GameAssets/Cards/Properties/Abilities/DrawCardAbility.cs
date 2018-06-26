using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class DrawCardAbility : Ability
    {
        public int NumCardsToDraw { get; private set; }
        public DrawCardAbility(int cost, int numCardsToDraw, int numTarget) : base(cost, numTarget)
        {
            this.NumCardsToDraw = numCardsToDraw;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
