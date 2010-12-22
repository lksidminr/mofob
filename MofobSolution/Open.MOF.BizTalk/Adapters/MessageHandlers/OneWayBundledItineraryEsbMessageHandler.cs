﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using Microsoft.Practices.ServiceLocation;

using Open.MOF.Messaging;

namespace Open.MOF.BizTalk.Adapters.MessageHandlers
{
    internal class OneWayBundledItineraryEsbMessageHandler : EsbMessageHandler<Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.ProcessRequestChannel>
    {
         public OneWayBundledItineraryEsbMessageHandler()
            : base()
        {
        }
 
        public OneWayBundledItineraryEsbMessageHandler(string channelEndpointName)
            : base(channelEndpointName)
        {
        }

        #region IESBMessageHandler Members

        public override string HandlerContext
        {
            get
            {
                string handlerType = this.GetType().AssemblyQualifiedName;
                string itineraryName = (((_cachedItineraryDescription != null) && (_cachedItineraryDescription.ItineraryName != null)) ? _cachedItineraryDescription.ItineraryName : String.Empty);
                string itineraryVersion = (((_cachedItineraryDescription != null) && (_cachedItineraryDescription.ItineraryVersion != null)) ? _cachedItineraryDescription.ItineraryVersion : String.Empty);
                string itineraryLocation = (((_cachedItineraryDescription != null) && (_cachedItineraryDescription.WasItineraryInCache.HasValue)) ? ((_cachedItineraryDescription.WasItineraryInCache.Value) ? "incache" : "lookup") : "notfound");
                return String.Format("<Handler type=\"{0}\"><Channel endpoint=\"{1}\" /><RecentItinerary name=\"{2}\" version=\"{3}\" location=\"{4}\" /></Handler>", handlerType, _channelEndpointName, itineraryName, itineraryVersion, itineraryLocation);
            }
        }

        public override bool CanSupportMessage(FrameworkMessage message)
        {
            bool messageHasSendToAddress = ((message.To != null) && (message.To.IsValid()));
            bool messageSupportsOneWay = !message.RequiresTwoWay;
            bool isMessageSupported = (messageHasSendToAddress && messageSupportsOneWay);

            return (isMessageSupported);
        }

        #endregion

        protected override IAsyncResult InvokeChannelBeginAync(Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.ProcessRequestChannel channel, 
            MessagingState messagingState, AsyncCallback messageDeliveredCallback)
        {
            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestRequest itineraryRequest =
                MapMessageToItineraryRequest(messagingState.RequestMessage);

            return channel.BeginSubmitRequest(itineraryRequest, messageDeliveredCallback, messagingState);
        }

        protected override FrameworkMessage InvokeChannelEndAsync(Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.ProcessRequestChannel channel, 
            IAsyncResult ar)
        {
            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestResponse response = 
                channel.EndSubmitRequest(ar);

            MessageSubmittedResponse responseMessage = new MessageSubmittedResponse();

            return responseMessage;
        }

        protected override FrameworkMessage InvokeChannelSync(Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.ProcessRequestChannel channel, 
            FrameworkMessage requestMessage)
        {
            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestRequest itineraryRequest =
                MapMessageToItineraryRequest(requestMessage);

            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestResponse response = 
                channel.SubmitRequest(itineraryRequest);

            MessageSubmittedResponse responseMessage = new MessageSubmittedResponse();

            return responseMessage;
        }

        private Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestRequest MapMessageToItineraryRequest(FrameworkMessage requestMessage)
        {
            System.ComponentModel.TypeConverter converter = new OneWayItineraryConverter();
            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.Itinerary itinerary = 
                (Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.Itinerary)converter.ConvertFrom(requestMessage);

            Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestRequest itineraryRequest = 
                new Open.MOF.BizTalk.Adapters.Proxy.ItineraryOneWayBundledServiceInstance.SubmitRequestRequest(itinerary, requestMessage.ToXmlString());

            return itineraryRequest;
        }
    }
}