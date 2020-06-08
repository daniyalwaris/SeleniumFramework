
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFramework
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver,this);
        }
    }
}
