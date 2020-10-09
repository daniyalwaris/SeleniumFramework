using OpenQA.Selenium.Chrome;
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
            Driver.driver = new ChromeDriver();
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
