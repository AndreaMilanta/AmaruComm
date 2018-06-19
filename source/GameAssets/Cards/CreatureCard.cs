using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class CreatureCard : Card
    {
        public int Health { get; set; }
        public int Energy { get; set; } = 0;
        public Shield Shield { get; private set; } = Shield.NONE;
        public Ability Ability { get; private set; }
        public Attack Attack { get; private set; }

        public CreatureCard(string name, int cost, int health, Attack attack, Ability ability = null, Shield shield = Shield.NONE, int id = AmaruConstants.AUTO_ID) : base(id, name, cost)
        {
            this.Health = health;
            this.Attack = attack;
            this.Ability = ability;
            this.Shield = shield;
        }
    }
}
