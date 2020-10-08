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

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            Navigate.LoginformThroughTheMenu();

            Thread.Sleep(200);

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");

            Navigate.LoginformAccessThroughTesPost();

            Thread.Sleep(200);

        }
    }



}
    
     