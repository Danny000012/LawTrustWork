using TechTalk.SpecFlow;
using ScriptingToFramework.Test.Drivers;
using ScriptingToFramework.Pages;
using ScriptingToFramework.Models;

namespace ScriptingToFramework.Test.StepDefinitions
{
    [Binding]
    public class Steps
    {
        private readonly Driver _driver;
        private readonly SignUpPage signUpPage;
        private readonly SignUpModel signUpModels;

        public Steps(Driver driver)
        {
            _driver = driver;
        }

        [Given(@"I Navigate to the signup page")]
        public void GivenPutYourBackgroundHere()
        {
            signUpPage.ClickSignUpLink(signUpModels);
        }

        [When(@"Put your Action here")]
        public void WhenPutYourActionHere()
        {
            _driver.ExecuteAction();
        }

        [Then(@"Put your Condition here")]
        public void ThenPutYourConditionHere()
        {
            _driver.CheckCondition();
        }
    }
}
