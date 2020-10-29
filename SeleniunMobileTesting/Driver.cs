
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public static class Driver
    {
        public static AppiumDriver<IWebElement> driver { get; set; }
        //public static IWebDriver driver = new ChromeDriver();
    }
}
