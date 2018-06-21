using System;

using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Players
{
    public class AmaruPlayer : Player
    {
        public AmaruPlayer(string logger) : base(CharacterEnum.AMARU, logger)
        {
            this.Health = AmaruConstants.INITIAL_AMARU_HEALTH;
        }
    }
}
