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
        public int Damage { get; private set; }

        public NewTurnResponse(CharacterEnum activePlayer, Card drawnCard, int damage = 0)
        {
            this.ActivePlayer = activePlayer;
            this.DrawnCard = drawnCard;
            this.HasDrawn = DrawnCard != null;
            this.Damage = damage;
        }
   
        public NewTurnResponse(CharacterEnum activePlayer, bool hasDrawn, int damage = 0)
        {
            this.ActivePlayer = activePlayer;
            this.HasDrawn = hasDrawn;
            this.Damage = damage;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
