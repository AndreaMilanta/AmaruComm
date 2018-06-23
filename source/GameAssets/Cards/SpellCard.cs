using System;
using System.Collections.Generic;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Players;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class SpellCard : Card
    {
        public bool Immediate { get { return Effect == null ? true : Effect.Immediate; } }

        public SpellAbility Effect { get; private set; }

        public SpellCard(CardEnum cardEnum, string name, int cost, SpellAbility effect = null, int id = AmaruConstants.AUTO_ID) : base(id, cardEnum, name, cost)
        {
            this.Effect = effect;
        }


        public override void Visit(PropertyVisitor visitor, CharacterEnum character, CardProperty property = null)
        {
            if (property != null)
                base.Visit(visitor, character, property);
            else
            {
                base.Visit(visitor, character, Effect);
            }
        }
        public SpellCard clone()
        {
            SpellCard card = (SpellCard)this.Original;
            return card;
        }
    }
}
