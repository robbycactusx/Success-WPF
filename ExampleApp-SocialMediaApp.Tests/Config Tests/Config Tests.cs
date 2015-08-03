using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuccessWPF;
using System.Configuration;

namespace ExampleApp_SocialMediaApp.Tests.Startup_Tests
{
    [TestClass]
    public class StartupTests
    {

        [TestMethod]
        public void Test_Can_Read_Version_Number_In_AppConfig()
        {
            var container = new Container();
            var version = container.Version;

            Assert.IsTrue(version.Major == 1, "Expected application to read 1 as major");
            Assert.IsTrue(version.Minor == 10, "Expected application to read 10 as minor");
            Assert.IsTrue(version.Build == 100, "Expected application to read 100 as build");
            Assert.IsTrue(version.Revision == 1000, "Expected application to read 1 as revision");
        }

        [TestMethod]
        [ExpectedException(typeof(ConfigurationErrorsException))]
        public void Test_NoConfig_Throws_ConfigurationErrorsException()
        {
            var container = new Container(null);
        }

    }
}
