﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://Microsoft.BizTalk.ESB/", ConfigurationName = "Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService.IProcessRequestResponse")]
    public interface IProcessRequestResponse
    {

        // CODEGEN: Generating message contract since message SubmitRequestResponse requires protection.
        [System.ServiceModel.OperationContractAttribute(Action = "SubmitRequestResponse", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService.SubmitRequestResponseResponse SubmitRequestResponse(Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService.SubmitRequestResponseRequest request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/itinerary")]
    public partial class ItineraryDescription
    {

        private string nameField;

        private string versionField;

        private string guidField;

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
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string Guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false, ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public partial class SubmitRequestResponseRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://schemas.microsoft.biztalk.practices.esb.com/itinerary", ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        public Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService.ItineraryDescription ItineraryDescription;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign, Order = 0)]
        public object part;

        public SubmitRequestResponseRequest()
        {
        }

        public SubmitRequestResponseRequest(Open.MOF.BizTalk.Test.TestStubs.ItineraryTwoWayService.ItineraryDescription ItineraryDescription, object part)
        {
            this.ItineraryDescription = ItineraryDescription;
            this.part = part;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false, ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public partial class SubmitRequestResponseResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "", ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign, Order = 0)]
        public object part;

        public SubmitRequestResponseResponse()
        {
        }

        public SubmitRequestResponseResponse(object part)
        {
            this.part = part;
        }
    }
}
