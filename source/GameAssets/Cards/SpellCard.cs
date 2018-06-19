using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class SpellCard : Card
    {
        public SpellAbility Effect { get; private set; }

        public SpellCard(string name, int cost, SpellAbility effect = null, int id = AmaruConstants.AUTO_ID) : base(cost, name, id)
        {
            this.Effect = effect;
        }
    }
}
