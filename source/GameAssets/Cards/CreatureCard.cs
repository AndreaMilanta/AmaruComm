using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Players;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class CreatureCard : Card
    {
        public int Health { get; set; }
        public int Energy { get; set; } = 0;
        public Shield Shield { get; private set; } = Shield.NONE;
        public CreatureEffect creatureEffect { get; private set; }
        public Ability Ability { get; private set; }
        public Attack Attack { get; private set; }

        public CreatureCard(CardEnum cardEnum, string name, int cost, int health, Attack attack, CreatureEffect creatureEffect = null, Ability ability = null, Shield shield = Shield.NONE, int id = AmaruConstants.AUTO_ID) : base(id, cardEnum, name, cost)
        {
            this.Health = health;
            this.Attack = attack;
            this.Ability = ability;
            this.Shield = shield;
            this.creatureEffect = creatureEffect;
        }

        public override void Visit(PropertyVisitor visitor, CharacterEnum character, CardProperty property = null)
        {
            if (property != null)
                base.Visit(visitor, character, property);
            else
            {
                base.Visit(visitor, character, Attack);
                base.Visit(visitor, character, Ability);
            }
        }
        public CreatureCard clone()
        {
            CreatureCard card = (CreatureCard)this.Original;
            card.Health = this.Health;
            card.Energy = this.Energy;
            card.Attack = this.Attack;
            card.Ability = this.Ability;
            card.creatureEffect = this.creatureEffect;
            card.Shield = this.Shield;
            card.Id = this.Id;
            return card;
        }
    }
}
