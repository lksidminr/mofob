﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Open.MOF.BizTalk.Services.Proxy.ItineraryServicesGenericOneWay
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://Microsoft.BizTalk.ESB/", ConfigurationName = "Open.MOF.BizTalk.Services.Proxy.ItineraryServicesGenericOneWay.ProcessRequest")]
    public interface ProcessRequest
    {
        
        // CODEGEN: Generating message contract since the operation SubmitRequest is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="SubmitRequest", ReplyAction="*")]
        SubmitRequestResponse SubmitRequest(SubmitRequestRequest request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://Microsoft.BizTalk.ESB/", ConfigurationName = "Open.MOF.BizTalk.Services.Proxy.ItineraryServicesGenericOneWay.ProcessRequestQueued")]
    public interface ProcessRequestQueued
    {

        // CODEGEN: Generating message contract since the operation SubmitRequest is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "SubmitRequest", IsOneWay = true)]
        void SubmitRequest(SubmitRequestRequest request);
    }
   
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitRequestRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public object part;
        
        public SubmitRequestRequest()
        {
        }
        
        public SubmitRequestRequest(object part)
        {
            this.part = part;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitRequestResponse
    {
        
        public SubmitRequestResponse()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ProcessRequestChannel : ProcessRequest, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ProcessRequestClient : System.ServiceModel.ClientBase<ProcessRequest>, ProcessRequest
    {
        
        public ProcessRequestClient()
        {
        }
        
        public ProcessRequestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ProcessRequestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProcessRequestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProcessRequestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SubmitRequestResponse ProcessRequest.SubmitRequest(SubmitRequestRequest request)
        {
            return base.Channel.SubmitRequest(request);
        }
        
        public void SubmitRequest(object part)
        {
            SubmitRequestRequest inValue = new SubmitRequestRequest();
            inValue.part = part;
            SubmitRequestResponse retVal = ((ProcessRequest)(this)).SubmitRequest(inValue);
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ProcessRequestQueuedChannel : ProcessRequestQueued, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ProcessRequestQueuedClient : System.ServiceModel.ClientBase<ProcessRequestQueued>, ProcessRequestQueued
    {

        public ProcessRequestQueuedClient()
        {
        }

        public ProcessRequestQueuedClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ProcessRequestQueuedClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ProcessRequestQueuedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ProcessRequestQueuedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void ProcessRequestQueued.SubmitRequest(SubmitRequestRequest request)
        {
            base.Channel.SubmitRequest(request);
        }

        public void SubmitRequest(object part)
        {
            SubmitRequestRequest inValue = new SubmitRequestRequest();
            inValue.part = part;
            ((ProcessRequest)(this)).SubmitRequest(inValue);
        }
    }
}