using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Actions
{
    public class MoveCreatureAction : PlayerAction
    {
        public Place Place { get; private set; }
        public int TablePos { get; private set; }

        public MoveCreatureAction(CharacterEnum caller, int playedCardId, Place place, int tablePos) : base(caller, playedCardId)
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
