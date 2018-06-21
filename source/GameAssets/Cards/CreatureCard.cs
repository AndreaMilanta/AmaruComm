﻿using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Players;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;

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

        public CreatureCard(string name, int cost, int health, Attack attack, CreatureEffect creatureEffect = null, Ability ability = null, Shield shield = Shield.NONE, int id = AmaruConstants.AUTO_ID) : base(id, name, cost)
        {
            this.Health = health;
            this.Attack = attack;
            this.Ability = ability;
            this.Shield = shield;
            this.creatureEffect = creatureEffect;
        }

        public override void Visit(PropertyVisitor visitor, Player player, CardProperty property = null)
        {
            if (property != null)
                base.Visit(visitor, player, property);
            else
            {
                base.Visit(visitor, player, Attack);
                base.Visit(visitor, player, Ability);
            }
        }
    }
}
