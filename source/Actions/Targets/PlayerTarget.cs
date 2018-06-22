using System;

using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Actions.Targets
{
    [Serializable]
    public class PlayerTarget : Target
    {
        public PlayerTarget(CharacterEnum character)
        {
            this.Character = character;
        }
    }
}
