using AmaruCommon.GameAssets.Characters;
using System;

namespace AmaruCommon.Actions.Targets
{
    [Serializable]
    public class Target
    {
        public CharacterEnum Character { get; protected set; }
    }
}
