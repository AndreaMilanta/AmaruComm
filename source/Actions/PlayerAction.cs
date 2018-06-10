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
        public Property PlayedProperty { get; private set; }

        public PlayerAction(CharacterEnum caller, int playedCardId, Property playedProperty)
        {
            this.Caller = caller;
            this.PlayedCardId = playedCardId;
            this.PlayedProperty = PlayedProperty;
        }

        /// <summary>
        /// Visitor implementation
        /// </summary>
        /// <param name="visitor"></param>
        public abstract void Visit(IActionVisitor visitor);
    }
}
