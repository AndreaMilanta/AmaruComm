using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    /*
    [Serializable]
    public struct CardMovement
    {
        public Place Source { get; private set; }
        public Place Dest { get; private set; }
        public CreatureCard Card { get; private set; }
        public CharacterEnum Owner { get; private set; }

        public CardMovement(CharacterEnum owner, Place source, Place dest, CreatureCard card)
        {
            this.Owner = owner;
            this.Source = source;
            this.Dest = dest;
            this.Card = card;
        }
    }

    [Serializable]
    public class CardsDrawnResponse : Response
    {
        public CharacterEnum Caller { get; private set; }
        public List<CardMovement> MovedCards { get; private set; }

        public CardsDrawnResponse(CharacterEnum caller, List<CardMovement> movedCards)
        {
            this.Caller = caller;
            this.MovedCards = movedCards; 
        }

        public CardsDrawnResponse(CharacterEnum caller, CardMovement movedCard)
        {
            this.Caller = caller;
            this.MovedCards = new List<CardMovement>() { movedCard };
        }

        public CardsDrawnResponse(CharacterEnum caller, CharacterEnum owner, Place source, Place dest, CreatureCard card)
        {
            this.Caller = caller;
            this.MovedCards = new List<CardMovement>() { new CardMovement(owner, source, dest, card) };
        }


        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }//*/
}
