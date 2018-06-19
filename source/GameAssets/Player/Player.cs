using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using AmaruCommon.Exceptions;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Player;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
using System.Linq;

namespace AmaruCommon.GameAssets.Player
{
    public class Player
    {
        // Properties
        public int Mana { get; set ; } = 0;
        public int Health { get; set; } = AmaruConstants.INITIAL_PLAYER_HEALTH;
        public bool IsShieldUpProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDUP || o.Shield == Shield.BOTH); }
        public bool IsShieldMaidenProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDMAIDEN || o.Shield == Shield.BOTH); }
        public bool IsAlive { get => Health > 0; }
        public bool InnerAttackAllowed { get { return (!PlayedSpell.Any() ? false : PlayedSpell.Exists(ps => ps.Effect is AttackFromInnerSpellAbility)); } }  // Effect of played spell card
        public bool IsImmune { get; set; } = false;
        public bool HasChanged { get; set; } = false;           // Wheter player has changed or not

        private int _initialTurnMana = 0;

        public int ManaPlayedCount { get => this.Mana - _initialTurnMana; }

        // Cards
        public Stack<Card> Deck { get; private set; } = null;
        public LimitedList<Card> Hand { get; private set; } = new LimitedList<Card>(AmaruConstants.HAND_MAX_SIZE);
        public LimitedList<CreatureCard> Inner { get; private set;} = new LimitedList<CreatureCard>(AmaruConstants.INNER_MAX_SIZE);
        public LimitedList<CreatureCard> Outer { get; private set; } = new LimitedList<CreatureCard>(AmaruConstants.OUTER_MAX_SIZE);
        public List<Card> Graveyard { get; private set; } = new List<Card>();
        public List<SpellCard> PlayedSpell { get; private set; } = null;
        private ReadOnlyDictionary<Place, IEnumerable<Card>> _cardDict; 

        // Communication
        public EnemyInfo AsEnemy { get => new EnemyInfo(Character, Health, Mana, Deck.Count, Hand.Count, Inner, Outer, PlayedSpell, IsImmune); }
        public OwnInfo AsOwn { get => new OwnInfo(Character,  Health, Mana, Deck.Count, Hand, Inner, Outer, PlayedSpell, IsImmune); }

        public CharacterEnum Character { get; private set; } = CharacterEnum.INVALID;
         
        public Player(CharacterEnum character)
        {
            Character = character;
            Deck = new Stack<Card>(DeckFactory.GetDeck(Character));
            // Initializes readonly dict
            _cardDict = new ReadOnlyDictionary<Place, IEnumerable<Card>>(new Dictionary<Place, IEnumerable<Card>>(){
                    {Place.DECK, Deck},
                    {Place.HAND, Hand},
                    {Place.INNER, Inner},
                    {Place.OUTER, Outer},
                    {Place.CEMETERY, Graveyard},
                });
        }

        public void Draw()
        {
            Hand.Add(Deck.Pop());
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

        public void ResetManaCount()
        {
            _initialTurnMana = this.Mana;
        }
    }
}
