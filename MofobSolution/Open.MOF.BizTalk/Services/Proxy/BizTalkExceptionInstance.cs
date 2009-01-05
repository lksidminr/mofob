﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Open.MOF.BizTalk.Services.Proxy
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://microsoft.biztalk.practices.esb.com/exceptionhandling/", ConfigurationName = "ExceptionHandling")]
    public interface ExceptionHandling
    {

        // CODEGEN: Generating message contract since the operation SubmitFault is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "SubmitFault", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        SubmitFaultResponse SubmitFault(SubmitFaultRequest request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://microsoft.biztalk.practices.esb.com/exceptionhandling/", ConfigurationName = "ExceptionHandlingOneWay")]
    public interface ExceptionHandlingOneWay
    {

        // CODEGEN: Generating message contract since the operation SubmitFault is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "SubmitFault", IsOneWay = true)]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        void SubmitFault(SubmitFaultRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessage
    {

        private FaultMessageHeader headerField;

        private FaultMessageExceptionObject exceptionObjectField;

        private FaultMessageMessage[] messagesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public FaultMessageHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public FaultMessageExceptionObject ExceptionObject
        {
            get
            {
                return this.exceptionObjectField;
            }
            set
            {
                this.exceptionObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Message", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public FaultMessageMessage[] Messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessageHeader
    {

        private string applicationField;

        private string descriptionField;

        private string errorTypeField;

        private string failureCategoryField;

        private string faultCodeField;

        private string faultDescriptionField;

        private int faultSeverityField;

        private string scopeField;

        private string serviceInstanceIDField;

        private string serviceNameField;

        private string faultGeneratorField;

        private string machineNameField;

        private string dateTimeField;

        private string controlBitField;

        private string messageIDField;

        private string activityIdentityField;

        private bool nACKField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string FailureCategory
        {
            get
            {
                return this.failureCategoryField;
            }
            set
            {
                this.failureCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string FaultCode
        {
            get
            {
                return this.faultCodeField;
            }
            set
            {
                this.faultCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string FaultDescription
        {
            get
            {
                return this.faultDescriptionField;
            }
            set
            {
                this.faultDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public int FaultSeverity
        {
            get
            {
                return this.faultSeverityField;
            }
            set
            {
                this.faultSeverityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public string Scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public string ServiceInstanceID
        {
            get
            {
                return this.serviceInstanceIDField;
            }
            set
            {
                this.serviceInstanceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 9)]
        public string ServiceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 10)]
        public string FaultGenerator
        {
            get
            {
                return this.faultGeneratorField;
            }
            set
            {
                this.faultGeneratorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 11)]
        public string MachineName
        {
            get
            {
                return this.machineNameField;
            }
            set
            {
                this.machineNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 12)]
        public string DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 13)]
        public string ControlBit
        {
            get
            {
                return this.controlBitField;
            }
            set
            {
                this.controlBitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 14)]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 15)]
        public string ActivityIdentity
        {
            get
            {
                return this.activityIdentityField;
            }
            set
            {
                this.activityIdentityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 16)]
        public bool NACK
        {
            get
            {
                return this.nACKField;
            }
            set
            {
                this.nACKField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessageExceptionObject
    {

        private string messageField;

        private string typeField;

        private string sourceField;

        private string targetSiteField;

        private string stackTraceField;

        private string innerExceptionMessageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string TargetSite
        {
            get
            {
                return this.targetSiteField;
            }
            set
            {
                this.targetSiteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string StackTrace
        {
            get
            {
                return this.stackTraceField;
            }
            set
            {
                this.stackTraceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string InnerExceptionMessage
        {
            get
            {
                return this.innerExceptionMessageField;
            }
            set
            {
                this.innerExceptionMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessageMessage
    {

        private string contentTypeField;

        private string messageNameField;

        private string routingURLField;

        private FaultMessageMessageContextProperty[] messageContextField;

        private string messageIDField;

        private string interchangeIDField;

        private string messageTypeField;

        private FaultMessageMessageMessageData messageDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string MessageName
        {
            get
            {
                return this.messageNameField;
            }
            set
            {
                this.messageNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string RoutingURL
        {
            get
            {
                return this.routingURLField;
            }
            set
            {
                this.routingURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ContextProperty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public FaultMessageMessageContextProperty[] MessageContext
        {
            get
            {
                return this.messageContextField;
            }
            set
            {
                this.messageContextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string InterchangeID
        {
            get
            {
                return this.interchangeIDField;
            }
            set
            {
                this.interchangeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public string MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public FaultMessageMessageMessageData MessageData
        {
            get
            {
                return this.messageDataField;
            }
            set
            {
                this.messageDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessageMessageContextProperty
    {

        private string nameField;

        private string valueField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.648")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling")]
    public partial class FaultMessageMessageMessageData
    {

        private System.Xml.XmlNode[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace = "http://www.w3.org/1999/xhtml", Order = 0)]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SubmitFaultRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/exceptionhandling", Order = 0)]
        public FaultMessage FaultMessage;

        public SubmitFaultRequest()
        {
        }

        public SubmitFaultRequest(FaultMessage FaultMessage)
        {
            this.FaultMessage = FaultMessage;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SubmitFaultResponse
    {

        public SubmitFaultResponse()
        {
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ExceptionHandlingChannel : ExceptionHandling, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ExceptionHandlingClient : System.ServiceModel.ClientBase<ExceptionHandling>, ExceptionHandling
    {

        public ExceptionHandlingClient()
        {
        }

        public ExceptionHandlingClient(string endpointConfigurationName)
            :
                base(endpointConfigurationName)
        {
        }

        public ExceptionHandlingClient(string endpointConfigurationName, string remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ExceptionHandlingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ExceptionHandlingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SubmitFaultResponse ExceptionHandling.SubmitFault(SubmitFaultRequest request)
        {
            return base.Channel.SubmitFault(request);
        }

        public void SubmitFault(FaultMessage FaultMessage)
        {
            SubmitFaultRequest inValue = new SubmitFaultRequest();
            inValue.FaultMessage = FaultMessage;
            SubmitFaultResponse retVal = ((ExceptionHandling)(this)).SubmitFault(inValue);
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ExceptionHandlingOneWayChannel : ExceptionHandlingOneWay, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ExceptionHandlingOneWayClient : System.ServiceModel.ClientBase<ExceptionHandlingOneWay>, ExceptionHandlingOneWay
    {

        public ExceptionHandlingOneWayClient()
        {
        }

        public ExceptionHandlingOneWayClient(string endpointConfigurationName)
            :
                base(endpointConfigurationName)
        {
        }

        public ExceptionHandlingOneWayClient(string endpointConfigurationName, string remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ExceptionHandlingOneWayClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public ExceptionHandlingOneWayClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void ExceptionHandlingOneWay.SubmitFault(SubmitFaultRequest request)
        {
            base.Channel.SubmitFault(request);
        }

        public void SubmitFault(FaultMessage FaultMessage)
        {
            SubmitFaultRequest inValue = new SubmitFaultRequest();
            inValue.FaultMessage = FaultMessage;
            ((ExceptionHandlingOneWay)(this)).SubmitFault(inValue);
        }
    }

}