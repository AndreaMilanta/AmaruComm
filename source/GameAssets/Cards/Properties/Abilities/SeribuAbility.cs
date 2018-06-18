using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class SeribuAbility : Ability
    {
        protected SeribuAbility(int cost) : base(cost)
        {
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
