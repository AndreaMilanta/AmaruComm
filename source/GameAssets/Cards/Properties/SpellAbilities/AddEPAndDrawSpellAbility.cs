using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public class AddEPAndDrawSpellAbility : SpellAbility
    {
        public int EpNumber { get; private set; }
        public int CardToDraw { get; private set; }

        protected AddEPAndDrawSpellAbility (int EpNumber=1, int CardToDraw=1) : base (true,1, Constants.KindOfTarget.PLAYER)
        {
            this.EpNumber = EpNumber;
            this.CardToDraw = CardToDraw;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
