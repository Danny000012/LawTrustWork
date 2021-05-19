using NUnit.Framework;
using ScriptingToFramework.Pages;
using Framework.Selenium;
using System.IO;
using ScriptingToFramework.Models;
using Newtonsoft.Json;

namespace ScriptingToFramework.Test
{
    public class LawTrustTests : TestSetup
    {
        [Test, Category("LawTrust")]
        public void LawTrustSignUpIndividualAccount()
        {
            string jsonPath = "C:\\Users\\dseabela\\Desktop\\FrameworkAssess\\ScriptingToFramework\\TestData\\SignUpData.json";
            string myJsonResponse = File.ReadAllText(jsonPath);
            SignUpModel signup = JsonConvert.DeserializeObject<SignUpModel>(myJsonResponse);

            basePage = new PageBase(Driver.Current);
            basePage.signUpPage.ClickSignUpLink(signup);
        }

        [Test, Category("LawTrust")]
        public void LawTrustSignUpPageEnterPriceAccount()
        {
            string jsonPath = "C:\\Users\\dseabela\\Desktop\\FrameworkAssess\\ScriptingToFramework\\TestData\\ProfileData.json";
            string myJsonResponse = File.ReadAllText(jsonPath);
            SignUpModel signup = JsonConvert.DeserializeObject<SignUpModel>(myJsonResponse);

            basePage = new PageBase(Driver.Current);
            basePage.signUpPage.SignUpCreateProfile(signup);
            basePage.accTypePage.SelectEnterPriceAccountType();
        }
    }
}