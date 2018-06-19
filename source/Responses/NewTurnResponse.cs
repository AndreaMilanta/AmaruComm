using System;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class NewTurnResponse : Response
    {
        public CharacterEnum ActivePlayer { get; private set; }
        public bool HasDrawn { get; private set; } = false;
        public Card DrawnCard { get; private set; } = null;

        public NewTurnResponse(CharacterEnum activePlayer, Card drawnCard)
        {
            this.ActivePlayer = activePlayer;
            this.DrawnCard = drawnCard;
            this.HasDrawn = DrawnCard != null;
        }
   
        public NewTurnResponse(CharacterEnum activePlayer, bool hasDrawn)
        {
            this.ActivePlayer = activePlayer;
            this.HasDrawn = hasDrawn;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
