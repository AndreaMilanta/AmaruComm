using System;

using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Cards;

namespace AmaruCommon.Actions.Targets
{
    [Serializable]
    public class CardTarget : Target
    {
        public int CardId { get; private set; }
        public CreatureCard Card { get; private set; } = null;

        public CardTarget(CharacterEnum character, int cardId)
        {
            this.Character = character;
            this.CardId = cardId;
        }

        public CardTarget(CharacterEnum character, CreatureCard card)
        {
            this.Character = character;
            this.Card = card;
            this.CardId = this.Card.Id;
        }

    }
}
