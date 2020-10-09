using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumFrameworkUsingScreenShotandReportGeneration
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver();

            string screenshotDirectory = Directory.GetCurrentDirectory() + @"\screenshot";
            chrome.Navigate().GoToUrl("https://google.com");


            Screenshot googlescreenshot = ((ITakesScreenshot)chrome).GetScreenshot();
            if (Directory.Exists(screenshotDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshot");

            }   

            googlescreenshot.SaveAsFile(Directory.GetCurrentDirectory()+ @"\screenshot\googlescreenshot.png" ,ScreenshotImageFormat.Png);
            chrome.Quit();
        }
    }
}
