using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class PlayACreatureFromHandAction : PlayerAction
    {
        public Place Place { get; private set; }
        public int TablePos { get; private set; }

        public PlayACreatureFromHandAction(CharacterEnum caller, int playedCardId, Place place, int tablePos ) : base(caller, playedCardId)
        {
            this.Place = place;
            this.TablePos = tablePos;
        }

        public override void Visit(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
