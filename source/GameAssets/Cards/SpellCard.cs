using System;
using System.Collections.Generic;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
using AmaruCommon.GameAssets.Players;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class SpellCard : Card
    {
        public SpellAbility Effect { get; private set; }

        public SpellCard(string name, int cost, SpellAbility effect = null, int id = AmaruConstants.AUTO_ID) : base(id, name, cost)
        {
            this.Effect = effect;
        }


        public override void Visit(PropertyVisitor visitor, Player player, CardProperty property = null)
        {
            if (property != null)
                base.Visit(visitor, player, property);
            else
            {
                base.Visit(visitor, player, Effect);
            }
        }
    }
}
