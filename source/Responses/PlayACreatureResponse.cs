using System;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class PlayACreatureResponse : Response
    {
        public CharacterEnum Caller { get; private set; }
        public CreatureCard Creature { get; private set; }
        public Place Place { get; private set; }
        public int TablePos { get; private set; }

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
