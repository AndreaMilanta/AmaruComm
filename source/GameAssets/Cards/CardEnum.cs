using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Cards
{
    [Serializable]
    public class CardEnum
    {
        public CharacterEnum Character { get; private set; }
        public Moraika MoraikaCard { get; private set; }
        public Leon LeonCard { get; private set; }
        public Luna LunaCard { get; private set; }
        public Yaku YakuCard { get; private set; }
        public Amaru AmaruCard { get; private set; }

        public Card Card {
            get {
                switch (Character)
                {
                    case CharacterEnum.MORAIKA:
                        return CardFactory.GetMoraikaCard(MoraikaCard);
                    case CharacterEnum.LEON:
                        return CardFactory.GetLeonCard(LeonCard);
                    case CharacterEnum.LUNA:
                        return CardFactory.GetLunaCard(LunaCard);
                    case CharacterEnum.YAKU:
                        return CardFactory.GetYakuCard(YakuCard);
                    case CharacterEnum.AMARU:
                        return CardFactory.GetAmaruCard(AmaruCard);
                    default:
                        return null;
                }
            }
        }

        // Moraika Constructor
        public CardEnum(Moraika cardEnum)
        {
            this.Character = CharacterEnum.MORAIKA;
            this.MoraikaCard = cardEnum;
        }

        // Leon Constructor
        public CardEnum(Leon cardEnum)
        {
            this.Character = CharacterEnum.LEON;
            this.LeonCard = cardEnum;
        }

        // Luna Constructor
        public CardEnum(Luna cardEnum)
        {
            this.Character = CharacterEnum.LUNA;
            this.LunaCard = cardEnum;
        }

        // Yaku Constructor
        public CardEnum(Yaku cardEnum)
        {
            this.Character = CharacterEnum.YAKU;
            this.YakuCard = cardEnum;
        }

        // Amaru Constructor
        public CardEnum(Amaru cardEnum)
        {
            this.Character = CharacterEnum.AMARU;
            this.AmaruCard = cardEnum;
        }

        public override bool Equals(object obj)
        {
            if (obj is CardEnum)
            {
                CardEnum target = (CardEnum)obj;
                if (this.Character == target.Character)
                    switch (this.Character)
                    {
                        case CharacterEnum.AMARU: return this.AmaruCard == target.AmaruCard;
                        case CharacterEnum.MORAIKA: return this.MoraikaCard == target.MoraikaCard;
                        case CharacterEnum.LEON: return this.LeonCard == target.LeonCard;
                        case CharacterEnum.LUNA: return this.LunaCard == target.LunaCard;
                        case CharacterEnum.YAKU: return this.YakuCard == target.YakuCard;
                        default: return false;
                    }
                return false;
            }
            else if (obj is Amaru)
                return (this.Character == CharacterEnum.AMARU && this.AmaruCard == (Amaru)obj);
            else if (obj is Moraika)
                return (this.Character == CharacterEnum.MORAIKA && this.MoraikaCard == (Moraika)obj);
            else if (obj is Leon)
                return (this.Character == CharacterEnum.LEON && this.LeonCard == (Leon)obj);
            else if (obj is Luna)
                return (this.Character == CharacterEnum.LUNA && this.LunaCard == (Luna)obj);
            else if (obj is Yaku)
                return (this.Character == CharacterEnum.YAKU && this.YakuCard == (Yaku)obj);
            return false;
        }
    }
}
