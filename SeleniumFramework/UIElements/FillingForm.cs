using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SeleniumFramework
{
    public class FillingForm
    {
        public FillingForm()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-72 > div > form > ul > li:nth-child(2) > input[type=text]")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-72 > div > form > ul > li:nth-child(4) > input[type=password]")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-72 > div > form > ul > li:nth-child(6) > input[type=password]")]
        public IWebElement RepeatPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-72 > div > form > ul > li:nth-child(7) > input[type=submit]")]
        public IWebElement Submit { get; set; }




    }
    
}
