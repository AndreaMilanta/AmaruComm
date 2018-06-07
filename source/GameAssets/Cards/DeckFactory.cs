using System;
using System.Collections.Generic;

using AmaruCommon.Constants;
using AmaruCommon.Exceptions;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Cards
{
    public static class DeckFactory
    {
        /// <summary>
        /// New shuffled Moraika Deck
        /// </summary>
        public static List<Card> MoraikaDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
        }); }
        
        /// <summary>
        /// New shuffled Luna Deck
        /// </summary>
        public static List<Card> LunaDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
        }); }

        /// <summary>
        /// New shuffled Leon Deck
        /// </summary>
        public static List<Card> LeonDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
        }); }

        /// <summary>
        /// New shuffled Yaku Deck
        /// </summary>
        public static List<Card> YakuDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
        }); }

        /// <summary>
        /// New shuffled Amaru Deck
        /// </summary>
        public static List<Card> AmaruDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
        }); }

        /// <summary>
        /// Returns a new shuffled deck of given character
        /// </summary>
        /// <param name="character"></param>
        /// <exception cref="InvalidCharacterException"></exception>
        /// <returns></returns>
        public static List<Card> GetDeck(CharacterEnum character)
        {
            switch (character)
            {
                case CharacterEnum.MORAIKA: return MoraikaDeck;
                case CharacterEnum.LUNA:    return LunaDeck;
                case CharacterEnum.LEON:    return LeonDeck;
                case CharacterEnum.YAKU:    return YakuDeck;
                case CharacterEnum.AMARU:   return AmaruDeck;
                default: throw new InvalidCharacterException();
            }
        }
    }
}
