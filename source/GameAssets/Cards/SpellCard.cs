using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class SpellCard : Card
    {
        public Effect Effect { get; private set; }

        public SpellCard(int cost, string name, Effect effect, int id = AmaruConstants.AUTO_ID) : base(cost, name, id)
        {
            this.Effect = effect;
        }
    }
}
