﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Open.MOF.Messaging
{
    public class MessageDeliveredEventArgs : MessagingEventArgs
    {
        public MessageDeliveredEventArgs(FrameworkMessage message) : base(message)
        {
        }
    }
}
