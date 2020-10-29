using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework
{
    public static class Action
    {
        public static void initializedriver()
        {
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
            DesiredCapabilities cap = new DesiredCapabilities();
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete

            cap.SetCapability(MobileCapabilityType)

            Driver.driver = new AndroidDriver<IWebElement>("http://127.0.0.1:4723/wd/hub",ICapabilities);
            Driver.driver.Navigate().GoToUrl(config.BaseURL);

        }
        public static void fillintheloginform( string username, string password, string Repeatpassword)
        {
            FillingForm flFm = new FillingForm();

            flFm.UserName.SendKeys(username);
            flFm.Password.SendKeys(password);
            flFm.RepeatPassword.SendKeys(Repeatpassword);
            flFm.Submit.Click();

        }
    }
}
