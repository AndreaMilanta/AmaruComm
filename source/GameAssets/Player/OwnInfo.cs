using System;
using System.Collections.Generic;
using System.Linq;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
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
        public LimitedList<Card> Hand { get; private set; }
        public LimitedList<CreatureCard> Inner { get; private set; }
        public LimitedList<CreatureCard> Outer { get; private set; }
        public List<SpellCard> PlayedSpell { get; private set; } = null;
        public bool IsShieldUpProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDUP || o.Shield == Shield.BOTH); }
        public bool IsShieldMaidenProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDMAIDEN || o.Shield == Shield.BOTH); }
        public bool IsAlive { get => Health > 0; }
        public bool InnerAttackAllowed { get { return (!PlayedSpell.Any() ? false : PlayedSpell.Exists(ps => ps.Effect is AttackFromInnerSpellAbility)); } }  // Effect of played spell card
        public bool IsImmune { get; set; } = false;

        public OwnInfo(CharacterEnum character, int health, int mana, int deckSize, LimitedList<Card> hand, LimitedList<CreatureCard> inner, LimitedList<CreatureCard> outer, List<SpellCard> playedSpell, bool immune)
        {
            this.Character = character;
            this.Health = health;
            this.Mana = mana;
            this.DeckSize = deckSize;
            this.Hand = hand;
            this.Inner = inner;
            this.Outer = outer;
            this.PlayedSpell = playedSpell;
            this.IsImmune = IsImmune;
        }
    }
}
