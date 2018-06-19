using System;

using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Actions.Targets
{
    [Serializable]
    public class PlayerTarget : Target
    {
        public CharacterEnum Character { get; private set; }

        public PlayerTarget(CharacterEnum character)
        {
            this.Character = character;
        }
    }
}
