using System;

using AmaruCommon.GameAssets.Characters;
using ClientServer.Messages;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class PlayerKilledMessage : Message
    {
        public CharacterEnum DeadCharacter { get; private set; }
        public bool Unexpected { get; private set; }                       // Connection was due to unexpected disconnection

        public PlayerKilledMessage(CharacterEnum deadCharacter, bool unexpected)
        {
            this.DeadCharacter = deadCharacter;
            this.Unexpected = unexpected;
        }
    }
}
