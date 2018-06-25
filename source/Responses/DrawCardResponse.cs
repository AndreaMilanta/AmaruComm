using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    public class DrawCardResponse : Response
    {
        public CharacterEnum Picker { get; private set; }
        public Card DrawnCard { get; private set; } = null;

        public DrawCardResponse(CharacterEnum picker, Card drawnCard)
        {
            this.Picker = picker;
            this.DrawnCard = drawnCard;
        }
   
        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
