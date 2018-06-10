using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using AmaruCommon.Exceptions;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Player;

namespace AmaruCommon.GameAssets.Player
{
    public class Player
    {
        // Properties
        public int Mana { get; set; } = 0;
        public int Health { get; set; } = AmaruConstants.INITIAL_PLAYER_HEALTH;
        public bool isShieldUpProtected { get => _outer.Exists(o => o.Shield == Shield.SHIELDUP); }
        public bool isShieldMaidenProtected { get => _outer.Exists(o => o.Shield == Shield.SHIELDMAIDEN); }

        // Cards
        private Stack<Card> _deck = null;
        private LimitedList<Card> _hand = new LimitedList<Card>(AmaruConstants.HAND_MAX_SIZE);
        private LimitedList<CreatureCard> _inner = new LimitedList<CreatureCard>(AmaruConstants.INNER_MAX_SIZE);
        private LimitedList<CreatureCard> _outer = new LimitedList<CreatureCard>(AmaruConstants.OUTER_MAX_SIZE);
        private List<Card> _cemetery = new List<Card>();
        private ReadOnlyDictionary<Place, IEnumerable<Card>> _cardDict; 

        // Communication
        public EnemyInfo AsEnemy { get => new EnemyInfo(Character, Health, Mana, _deck.Count, _hand.Count, _inner, _outer); }
        public OwnInfo AsOwn { get => new OwnInfo(Character,  Health, Mana, _deck.Count, _hand, _inner, _outer); }

        public CharacterEnum Character { get; private set; } = CharacterEnum.INVALID;
         
        public Player(CharacterEnum character)
        {
            Character = character;
            _deck = new Stack<Card>(DeckFactory.GetDeck(Character));
            // Initializes readonly dict
            _cardDict = new ReadOnlyDictionary<Place, IEnumerable<Card>>(new Dictionary<Place, IEnumerable<Card>>(){
                    {Place.DECK, _deck},
                    {Place.HAND, _hand},
                    {Place.INNER, _inner},
                    {Place.OUTER, _outer},
                    {Place.CEMETERY, _cemetery},
                });
        }

        public void Draw()
        {
            _hand.Add(_deck.Pop());
        }

        public void Draw(int amount)
        {
            for (int i = 0; i < amount; i++)
                this.Draw();
        }

        /// <summary>
        /// Returns Card with given id in given place if exists, null otherwise
        /// </summary>
        /// <param name="id"></param>
        /// <param name="place">Place.DECK not allowed</param>
        /// <returns></returns>
        public Card GetCardFromId(int id, Place place)
        {
            if (place == Place.DECK)
                throw new InvalidSearchLocation();
            return ((List<Card>)_cardDict[place]).Find(c => c.Id == id);
        }
    }
}
