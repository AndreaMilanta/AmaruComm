using System;
using System.Collections.Generic;

using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Player
{
    [Serializable]
    public class OwnInfo
    {
        public CharacterEnum Character { get; private set; }
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int DeckSize { get; private set; }
        public List<Card> Hand { get; private set; }
        public List<Card> Inner { get; private set; }
        public List<Card> Outer { get; private set; }

        public OwnInfo(CharacterEnum character, int health, int mana, int deckSize, List<Card> hand, List<Card> inner, List<Card> outer)
        {
            this.Character = character;
            this.Health = health;
            this.Mana = mana;
            this.DeckSize = deckSize;
            this.Hand = hand;
            this.Inner = inner;
            this.Outer = outer;
        }
    }
}
