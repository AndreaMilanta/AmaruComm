using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Actions.Targets;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class EndTurnAction : PlayerAction
    {
        public bool IsMainTurn { get; private set; }
        
        public EndTurnAction(CharacterEnum caller, int playedCardId, bool isMainTurn) : base(caller, playedCardId)
        {
            this.IsMainTurn = isMainTurn;
        }

        public override void Visit(IActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}