﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Open.MOF.Messaging
{
    public class MessageReceivedEventArgs : MessagingEventArgs
    {
        public MessageReceivedEventArgs(ResponseMessage message)
            : base(message)
        {
        }
    }
}
