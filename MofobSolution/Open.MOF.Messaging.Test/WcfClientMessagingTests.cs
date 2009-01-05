﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Open.MOF.Messaging;
using Open.MOF.Messaging.Services;

namespace Open.MOF.Messaging.Test
{
    /// <summary>
    /// Summary description for WcfClientMessagingTests
    /// </summary>
    [TestClass]
    public class WcfClientMessagingTests
    {
        private static System.ServiceModel.ServiceHost _serviceHost;
        private IAsyncResult _asyncResult;
        private System.Threading.AutoResetEvent _waitHandle;

        public WcfClientMessagingTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void TestSubmitMesssage()
        {
            Open.MOF.Messaging.Test.TestDataRequestMessage testMessage = new Open.MOF.Messaging.Test.TestDataRequestMessage("MessageName");
            using (MessagingService service = MessagingService.CreateInstance(testMessage.GetType()))
            {
                Assert.IsNotNull(service, "No item was returned.");
                Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
                Assert.AreEqual(service.BindingName, "myDataServiceBinding", "An incorrect item was returned.");
                Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

                MessageBase responseMessage = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage, "No item was returned.");
                Assert.AreEqual(responseMessage.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
            }
        }

        [TestMethod]
        public void TestSubmitMesssageAsync()
        {
            Open.MOF.Messaging.Test.TestDataRequestMessage testMessage = new Open.MOF.Messaging.Test.TestDataRequestMessage("MessageName");
            using (MessagingService service = MessagingService.CreateInstance(testMessage.GetType()))
            {
                Assert.IsNotNull(service, "No item was returned.");
                Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
                Assert.AreEqual(service.BindingName, "myDataServiceBinding", "An incorrect item was returned.");
                Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

                _asyncResult = null;
                IAsyncResult ar = service.BeginSubmitMessage(testMessage, null, new AsyncCallback(MessageDeliveredCallback));

                _waitHandle = new System.Threading.AutoResetEvent(false);
                _waitHandle.WaitOne();

                MessageBase responseMessage = null;
                if (_asyncResult != null)
                {
                    responseMessage = service.EndSubmitMessage(_asyncResult);
                }

                Assert.IsNotNull(responseMessage, "No item was returned.");
                Assert.AreEqual(responseMessage.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
            }
        }

        [TestMethod]
        public void TestSubmitMesssageClientProxy()
        {
            Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataRequestMessage testMessage = new Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataRequestMessage();
            testMessage.name = "MessageName";
            using (MessagingService service = MessagingService.CreateInstance(testMessage.GetType()))
            {
                Assert.IsNotNull(service, "No item was returned.");
                Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
                Assert.AreEqual(service.BindingName, "myDataServiceBinding", "An incorrect item was returned.");
                Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

                MessageBase responseMessage = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage, "No item was returned.");
                Assert.AreEqual(responseMessage.GetType(), typeof(Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.name, ((Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage)responseMessage).value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage)responseMessage).MessageId, ((Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage)responseMessage).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.WcfServiceProxyReference.TestDataResponseMessage)responseMessage).RelatedMessageId, "An incorrect item was returned.");
            }
        }

        [TestMethod]
        public void TestMultipleSubmitMesssage()
        {
            Open.MOF.Messaging.Test.TestDataRequestMessage testMessage = new Open.MOF.Messaging.Test.TestDataRequestMessage("MessageName");
            using (MessagingService service = MessagingService.CreateInstance(testMessage.GetType()))
            {
                Assert.IsNotNull(service, "No item was returned.");
                Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
                Assert.AreEqual(service.BindingName, "myDataServiceBinding", "An incorrect item was returned.");
                Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
                Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

                MessageBase responseMessage1 = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage1, "No item was returned.");
                Assert.AreEqual(responseMessage1.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).RelatedMessageId, "An incorrect item was returned.");

                MessageBase responseMessage2 = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage2, "No item was returned.");
                Assert.AreEqual(responseMessage2.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, "An incorrect item was returned.");

                MessageBase responseMessage3 = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage3, "No item was returned.");
                Assert.AreEqual(responseMessage3.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, "An incorrect item was returned.");

                MessageBase responseMessage4 = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage4, "No item was returned.");
                Assert.AreEqual(responseMessage4.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, "An incorrect item was returned.");

                MessageBase responseMessage5 = service.SubmitMessage(testMessage);

                Assert.IsNotNull(responseMessage5, "No item was returned.");
                Assert.AreEqual(responseMessage5.GetType(), typeof(Open.MOF.Messaging.Test.TestDataResponseMessage), "An incorrect type was returned.");
                Assert.AreEqual(testMessage.Name, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).Value, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, "An incorrect item was returned.");
                Assert.AreEqual(testMessage.MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).RelatedMessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage1).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage2).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage3).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, "An incorrect item was returned.");
                Assert.AreNotEqual(((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage4).MessageId, ((Open.MOF.Messaging.Test.TestDataResponseMessage)responseMessage5).MessageId, "An incorrect item was returned.");
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void RunBeforeAllTests(TestContext testContext)
        {
            RunServiceHost();
        }

        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void RunAfterAllTests()
        {
            StopServiceHost();
        }

        // Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void RunBeforeEachTest()
        {
        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void RunAfterEachTest()
        {
        }

        #endregion

        protected void MessageDeliveredCallback(IAsyncResult ar)
        {
            _asyncResult = ar;
            _waitHandle.Set();
        }

        private static void RunServiceHost()
        {
            _serviceHost = new System.ServiceModel.ServiceHost(typeof(Open.MOF.Messaging.Test.WcfService.TestDataService));
            _serviceHost.Open();
        }
        private static void StopServiceHost()
        {

            if (_serviceHost != null)
                _serviceHost.Close();
        }
    }
}
