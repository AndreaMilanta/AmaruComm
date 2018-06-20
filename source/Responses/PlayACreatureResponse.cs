using System;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class PlayACreatureResponse : Response
    {
        public CharacterEnum Caller { get; set; }
        public CreatureCard Creature { get; set; }
        public Place Place { get; set; }
        public int TablePos { get; set; }

        public PlayACreatureResponse(CharacterEnum caller, CreatureCard creature, Place place, int tablePos)
        {
            this.Caller = caller;
            this.Creature = creature;
            this.Place = place;
            this.TablePos = tablePos;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
