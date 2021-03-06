﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace Open.MOF.Messaging
{
    [MessageContract(IsWrapped = true, WrapperName = "UnsubscribeRequestMessage", WrapperNamespace = "http://mof.open/Messaging/ServiceContracts/1/0/")]
    public class UnsubscribeRequestMessage : FrameworkMessage 
    {
        [MessageBodyMember(Name = "subscriptionMessageXmlType", Order = 1, Namespace = "http://mof.open/Messaging/DataContracts/1/0/")]
        private string _subscriptionMessageXmlType;
        public string SubscriptionMessageXmlType
        {
            get { return _subscriptionMessageXmlType; }
            set { _subscriptionMessageXmlType = value; }
        }

        [MessageBodyMember(Name = "endpointUri", Order = 2, Namespace = "http://mof.open/Messaging/DataContracts/1/0/")]
        private string _endpointUri;
        public string EndpointUri
        {
            get { return _endpointUri; }
            set { _endpointUri = value; }
        }

        [MessageBodyMember(Name = "action", Order = 3, Namespace = "http://mof.open/Messaging/DataContracts/1/0/")]
        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        public static MessageBehavior Behavior
        {
            get
            {
                return MessageBehavior.SubscriptionControl;
            }
        }
    }
}
