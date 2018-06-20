using System;
using System.Collections.Generic;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class NewTurnResponse : Response
    {
        public int CurrentRound { get; private set; }
        public CharacterEnum ActivePlayer { get; private set; }
        public int NewMana { get; private set; }
        public bool HasDrawn { get; private set; } = false;
        public Card DrawnCard { get; private set; } = null;
        public List<Card> ModifiedCards { get; private set; } = null;
        public int Damage { get; private set; }

        public NewTurnResponse(int currentRound, CharacterEnum activePlayer, int newMana, Card drawnCard, List<Card> modifiedCards, int damage = 0)
        {
            this.CurrentRound = currentRound;
            this.ActivePlayer = activePlayer;
            this.NewMana = newMana;
            this.DrawnCard = drawnCard;
            this.HasDrawn = DrawnCard != null;
            this.ModifiedCards = modifiedCards;
            this.Damage = damage;
        }
   
        public NewTurnResponse(int currentRound, CharacterEnum activePlayer, int newMana, bool hasDrawn, List<Card> modifiedCards, int damage = 0)
        {
            this.CurrentRound = currentRound;
            this.ActivePlayer = activePlayer;
            this.NewMana = newMana;
            this.HasDrawn = hasDrawn;
            this.Damage = damage;
            this.ModifiedCards = modifiedCards;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
