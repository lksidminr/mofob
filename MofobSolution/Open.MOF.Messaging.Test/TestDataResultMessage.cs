﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

using Open.MOF.Messaging;

namespace Open.MOF.Messaging.Test
{
    [MessageContract(IsWrapped = true, WrapperName = "TestDataResponseMessage", WrapperNamespace = "http://mofob.open/MessagingTests/ServiceContracts/1/0/")]
    public class TestDataResponseMessage : ResponseMessage<TestDataResponseMessage>
    {
        public TestDataResponseMessage() : base()
        {
            _value = null;
        }

        public TestDataResponseMessage(string value) : base()
        {
            _value = value;
        }

        [MessageBodyMember(Name = "value", Order = 1, Namespace = "http://mofob.open/MessagingTests/DataContracts/1/0/")]
        protected string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
