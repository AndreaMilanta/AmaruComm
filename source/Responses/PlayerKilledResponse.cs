using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class PlayerKilledResponse : Response
    {
        public CharacterEnum Killer { get; private set; } = CharacterEnum.INVALID;
        public CharacterEnum Dead { get; private set; } = CharacterEnum.INVALID;
        public bool GetsImmunity { get; private set; } = false;
        public int DrawnCardsNum { get; private set; } = 0;
        public List<Card> DrawnCards { get; private set; } = null;

        public PlayerKilledResponse(CharacterEnum killer, CharacterEnum dead, bool getsImmunity, List<Card> drawnCards)
        {
            this.Killer = killer;
            this.Dead = dead;
            this.GetsImmunity = getsImmunity;
            this.DrawnCards = drawnCards;
            this.DrawnCardsNum = DrawnCards.Count;
        }

        public PlayerKilledResponse(CharacterEnum killer, CharacterEnum dead, bool getsImmunity, int drawnCardsNum)
        {
            this.Killer = killer;
            this.Dead = dead;
            this.GetsImmunity = getsImmunity;
            this.DrawnCardsNum = drawnCardsNum;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
