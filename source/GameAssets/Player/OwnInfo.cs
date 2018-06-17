using System;
using System.Collections.Generic;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

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
        public List<CreatureCard> Inner { get; private set; }
        public List<CreatureCard> Outer { get; private set; }
        public SpellCard PlayedSpell { get; private set; } = null;
        public bool IsShieldUpProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDUP); }
        public bool IsShieldMaidenProtected { get => Outer.Exists(o => o.Shield == Shield.SHIELDMAIDEN); }
        public bool IsAlive { get => Health > 0; }
        public bool InnerAttackAllowed { get => Outer.Exists(c => c.Effect is AttackFromInnerEffect) ||                         // Effect of card in outer
                                                Inner.Exists(c => c.Effect is AttackFromInnerEffect) ||                         // Effect of card in inner
                                                (PlayedSpell == null ? false : PlayedSpell.Effect is AttackFromInnerEffect); }  // Effect of played spell card
        public bool IsImmune { get; set; } = false;

        public OwnInfo(CharacterEnum character, int health, int mana, int deckSize, List<Card> hand, List<CreatureCard> inner, List<CreatureCard> outer, SpellCard playedSpell, bool immune)
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
