using SeleniumFramework.UIElements;

namespace SeleniumFramework
{
    public static class Navigate
    {
        public static void LoginformThroughTheMenu()
         {
            Menu menu = new Menu();
            TestScenarioPage tspage = new TestScenarioPage();
            menu.TestScenarios.Click();
            tspage.LoginForm.Click();
        }

        public static void LoginformAccessThroughTesPost()
        {
            Menu menu = new Menu();
            TestCasePage tcpage = new TestCasePage();
            UserNameField usmanf = new UserNameField();

            menu.TestCases.Click();
            tcpage.UsernameFieldinLoginForm.Click();
            usmanf.LoginFormLink.Click();
        }
    }
}
