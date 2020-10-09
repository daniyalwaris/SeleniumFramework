using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Test_Scenario
{
    class Login_with_invalid_user
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Initial()
        {
            Action.initializedriver();
            Navigate.LoginformAccessThroughTesPost();
        }

        [Test]
        public void invalidloginwithThirteencharacter()
        {
            Action.fillintheloginform(config.Credentials.Invalid.Username.ThirteenCharacter, config.Credentials.Valid.Password, config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(config.AlertMessages.Successfullogin, alert.Text);
            alert.Accept();

        }
 
        [Test]
        public void invalidloginwithfourcharacter()
        {
            Action.fillintheloginform(config.Credentials.Invalid.Username.FourCharacters, config.Credentials.Valid.Password, config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(config.AlertMessages.Successfullogin, alert.Text);
            alert.Accept();

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();

        }

    }
}
