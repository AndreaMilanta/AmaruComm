using System;

using AmaruCommon.Constants;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class SpellCard : Card
    {
        public SpellCard(int cost, int id = AmaruConstants.AUTO_ID) : base(cost, id)
        {

        }
    }
}
