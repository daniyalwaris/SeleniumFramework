using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace SeleniumFramework
{
    public class EntryPoint
    {
        static void Main()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Navigate().GoToUrl("https://www.google.com/");
            // Thread.Sleep(3000);
            // driver.Quit();

            Menu menu = new Menu();
            Driver.driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            menu.Selectors.Click();
        }
    }



}
    
     