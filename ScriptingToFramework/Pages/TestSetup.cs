using NUnit.Framework;
using Framework.Selenium;
using AventStack.ExtentReports;
using System;

namespace ScriptingToFramework.Pages
{
    public class TestSetup
    {
        public PageBase basePage;

        //Instance of extents reports
        public static ExtentReports extent;
        public static ExtentTest test;

        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            Driver.Current.Url = "https://uatweb.signinghub.co.za/";
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }
    }
}