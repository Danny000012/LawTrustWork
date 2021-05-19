using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace ScriptingToFramework.Pages
{
    public class AccTypePage
    {
        public readonly AccTypePageMap Map;

        public AccTypePage(IWebDriver driver)
        {
            Map = new AccTypePageMap(driver);
        }

        public void SelectIndividualAccountType()
        {
            var header = Map.AccTypeHeader.Text;
            Assert.AreEqual("SELECT ACCOUNT TYPE", header);
            Map.RadIndividualAcc.Click();
            Map.TrialPlan.Click();
            Map.AccTypeBtnNext.Click();
        }

        public void SelectEnterPriceAccountType()
        {
            var header = Map.AccTypeHeader.Text;
            Assert.AreEqual("SELECT ACCOUNT TYPE", header);
            Map.RadEnterPriceAcc.Click();
            Map.TrialPlan.Click();
            //implement wait
            Thread.Sleep(5000);
            Map.AccTypeBtnNext.Click();
        }
    }

    public class AccTypePageMap
    {
        IWebDriver _driver;

        public AccTypePageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement AccTypeHeader => _driver.FindElement(By.XPath("//h1[text()='SELECT ACCOUNT TYPE']"));
        public IWebElement RadIndividualAcc => _driver.FindElement(By.XPath("(//div[@class='radio'])[1]"));
        public IWebElement RadEnterPriceAcc => _driver.FindElement(By.XPath("(//div[@class='radio'])[2]"));
        public IWebElement TrialPlan => _driver.FindElement(By.XPath("//span[@class='radio']"));
        public IWebElement AccTypeBtnNext => _driver.FindElement(By.XPath("//button[@type='submit']"));
    }
}