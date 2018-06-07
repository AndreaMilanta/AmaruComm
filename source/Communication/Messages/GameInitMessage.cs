using System;
using System.Collections.Generic;

using ClientServer.Messages;
using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Player;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class GameInitMessage : Message
    {
        public Dictionary<CharacterEnum, EnemyInfo> EnemyDict { get; private set; }
        public OwnInfo Own { get; private set; }
        
        public GameInitMessage(Dictionary<CharacterEnum, EnemyInfo> enemyDict, OwnInfo own)
        {
            this.EnemyDict = enemyDict;
            this.Own = own;
        }
    }
}
