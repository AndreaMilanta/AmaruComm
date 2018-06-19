using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public class ResurrectOrReturnToHandSpellAbility : SpellAbility
    {
        public Place myZone { get; private set; }
        protected ResurrectOrReturnToHandSpellAbility(Place myZone)
        {
            this.myZone = myZone;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}