﻿using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Open.MOF.Messaging;
using Open.MOF.Messaging.Services;

namespace Open.MOF.Messaging.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class MessagingServiceInstantiationTests
    {
        public MessagingServiceInstantiationTests()
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
        public void InstantiateServiceByNameTest()
        {
            MessagingService service = MessagingService.CreateInstance("WcfClientMessagingService");

            Assert.IsNotNull(service, "No item was returned.");
            Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
            Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");
        }

        [TestMethod]
        public void InstantiateServiceByInterfaceTypeTest()
        {
            MessagingService service = MessagingService.CreateInstance(ServiceInterfaceType.DataService);

            Assert.IsNotNull(service, "No item was returned.");
            Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
            Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

            service = MessagingService.CreateInstance(ServiceInterfaceType.TransactionService);

            Assert.IsNull(service, "An item was returned when none was expected.");

            service = MessagingService.CreateInstance(ServiceInterfaceType.ExceptionService);

            Assert.IsNull(service, "An item was returned when none was expected.");

            service = MessagingService.CreateInstance(ServiceInterfaceType.SubscriptionService);

            Assert.IsNull(service, "An item was returned when none was expected.");
        }

        [TestMethod]
        public void InstantiateServiceByMessageTypeTest()
        {
            MessagingService service = MessagingService.CreateInstance(typeof(TestDataRequestMessage));

            Assert.IsNotNull(service, "No item was returned.");
            Assert.AreEqual(service.GetType(), typeof(WcfClientMessagingService), "An incorrect type was returned.");
            Assert.IsTrue((service.CanSupportInterface(ServiceInterfaceType.DataService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.TransactionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.ExceptionService)), "An incorrect item was returned.");
            Assert.IsFalse((service.CanSupportInterface(ServiceInterfaceType.SubscriptionService)), "An incorrect item was returned.");

            service = MessagingService.CreateInstance(typeof(TestTransactionRequestMessage));

            Assert.IsNull(service, "An item was returned when none was expected.");

            service = MessagingService.CreateInstance(typeof(FaultMessage));

            Assert.IsNull(service, "An item was returned when none was expected.");

            service = MessagingService.CreateInstance(typeof(SubscribeRequestMessage));

            Assert.IsNull(service, "An item was returned when none was expected.");

            service = MessagingService.CreateInstance(typeof(UnsubscribeRequestMessage));

            Assert.IsNull(service, "An item was returned when none was expected.");
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void RunBeforeAllTests(TestContext testContext) 
        {
        }
        
        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void RunAfterAllTests() 
        {
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
    }
}
