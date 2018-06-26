using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{/*
    [Serializable]
    public class CardStealingResponse : Response
    {
        public CharacterEnum Caller { get; private set; }
        public CharacterEnum PreviousOwner { get; private set; }0
        public 

        public CardStealingResponse(CharacterEnum caller, List<CardMovement> movedCards)
        {
            this.Caller = caller;
            this.MovedCards = movedCards; 
        }

        public CardStealingResponse(CharacterEnum caller, CardMovement movedCard)
        {
            this.Caller = caller;
            this.MovedCards = new List<CardMovement>() { movedCard };
        }

        public CardStealingResponse(CharacterEnum caller, CharacterEnum owner, Place source, Place dest, CreatureCard card)
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
