using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Effects;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class CreatureCard : Card
    {
        public int Health { get; set; }
        public int Energy { get; set; } = 0;
        public Shield Shield { get; private set; } = Shield.NONE;
        public Effect Effect { get; private set; }
        public Ability Ability { get; private set; }
        public Attack Attack { get; private set; }

        public CreatureCard(string name, int cost, int health, Attack attack, Ability ability = null, Effect effect = null, Shield shield = Shield.NONE, int id = AmaruConstants.AUTO_ID) : base(id, name, cost)
        {
            this.Health = health;
            this.Attack = attack;
            this.Ability = ability;
            this.Effect = effect;
            this.Shield = shield;
        }
    }
}
