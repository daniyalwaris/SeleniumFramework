

using SeleniumExtras.PageObjects;
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
