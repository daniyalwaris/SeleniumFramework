using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumFramework.Test_Scenario
{
    class Login_Valid_User
    {
        IAlert alert;
        [OneTimeSetUp]
        public void Initial()
        {
            Action.initializedriver();
            Navigate.LoginformAccessThroughTesPost();
        }

        [Test]
        public void validlogin()
        {
            Action.fillintheloginform(config.Credentials.Valid.Username, config.Credentials.Valid.Password, config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(config.AlertMessages.Successfullogin, alert.Text);
            alert.Accept();

        }
        [OneTimeTearDown] // This  case it allow only once and then exit and then execute
        //[TearDown] Difference is that it allow to use multiple time
        public void CleanUp()
        {
            Driver.driver.Quit();

        }


    }
}
