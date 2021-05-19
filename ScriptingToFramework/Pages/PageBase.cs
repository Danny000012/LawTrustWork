using OpenQA.Selenium;
using Framework.Selenium;

namespace ScriptingToFramework.Pages
{
    public class PageBase
    {
        public readonly  SignUpPage signUpPage;

        public readonly AccTypePage accTypePage;

        public PageBase(IWebDriver driver)
        {
            signUpPage = new SignUpPage(Driver.Current);
            accTypePage = new AccTypePage(Driver.Current);
        }

        public SignUpPage signUp { get; }
        public AccTypePage accType { get; }
    }
}