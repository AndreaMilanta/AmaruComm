using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties;

namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    class AddEPAndDrawSpellAbility : SpellAbility
    {
        public int EpNumber { get; private set; }
        public int CardToDraw { get; private set; }

        public AddEPAndDrawSpellAbility (int EpNumber=1, int CardToDraw=1)
        {
            this.EpNumber = EpNumber;
            this.CardToDraw = CardToDraw;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
