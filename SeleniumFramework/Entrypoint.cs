using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
internal class EntryPoint
{
    private static void Main()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com/");
        Thread.Sleep(3000);
        driver.Quit();

    }
} 