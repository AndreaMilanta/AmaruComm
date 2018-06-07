using System;
using System.Collections.Generic;

using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Cards;

namespace AmaruCommon.GameAssets.Player
{
    [Serializable]
    public class EnemyInfo
    {
        public CharacterEnum Character { get; private set; }
        public int Health { get; private set; }
        public int Mana { get; private set; }
        public int DeckSize { get; private set; }
        public int HandSize { get; private set; }
        public List<Card> Inner { get; private set; }
        public List<Card> Outer { get; private set; }

        public EnemyInfo(CharacterEnum character, int health, int mana, int deckSize, int handSize, List<Card> inner, List<Card> outer)
        {
            this.Character = character;
            this.Health = health;
            this.Mana = mana;
            this.DeckSize = deckSize;
            this.HandSize = handSize;
            this.Inner = inner;
            this.Outer = outer;
        }
    }
}
