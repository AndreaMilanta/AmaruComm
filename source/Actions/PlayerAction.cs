using System;

using AmaruCommon.GameAssets.Characters;
using AmaruCommon.Constants;

namespace AmaruCommon.Actions
{
    [Serializable]
    public abstract class PlayerAction
    {
        public CharacterEnum Caller { get; private set; }
        public int PlayedCardId { get; private set; }

        public PlayerAction(CharacterEnum caller, int playedCardId)
        {
            this.Caller = caller;
            this.PlayedCardId = playedCardId;
        }

        /// <summary>
        /// Visitor implementation
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Visit(ActionVisitor visitor);
    }
}
