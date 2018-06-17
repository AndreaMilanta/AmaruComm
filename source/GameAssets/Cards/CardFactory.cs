using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards
{
    public class CardFactory
    {
        public static Card GetMoraikaCard(Moraika card)
        {
            switch (card)
            {
                case Moraika.Imperia:
                    return new CreatureCard("Imperia", 5, 5, new ImperiaAttack(1));
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetLunaCard(Luna card)
        {
            switch (card)
            {
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetLeonCard(Leon card)
        {
            switch (card)
            {
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetYakuCard(Yaku card)
        {
            switch (card)
            {
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetAmaruCard(Amaru card)
        {
            switch (card)
            {
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
