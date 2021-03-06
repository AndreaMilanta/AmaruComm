﻿using System;

using ClientServer.Messages;
using AmaruCommon.Actions;

namespace AmaruCommon.Communication.Messages
{
    [Serializable]
    public class ActionMessage : Message
    {
        public PlayerAction Action { get; private set; }
        
        public ActionMessage(PlayerAction action)
        {
            this.Action = action;
        }

    }
}
