using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmaruCommon.GameAssets.Cards;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class CardsModifiedResponse : Response
    {
        public List<CreatureCard> Cards { get; set; }

        public CardsModifiedResponse(List<CreatureCard> cards)
        {
            this.Cards = cards;
        }

        public CardsModifiedResponse(CreatureCard card)
        {
            this.Cards = new List<CreatureCard>() { card };
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
