using System;

using AmaruCommon.Responses;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    public class NewTurnResponse : Response
    {
        public CharacterEnum ActivePlayer { get; private set; }

        public NewTurnResponse(CharacterEnum activePlayer)
        {
            this.ActivePlayer = activePlayer;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
