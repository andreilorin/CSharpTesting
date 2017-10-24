using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System.Configuration;

namespace CSharpTesting.StepDefinitions
{
    public class Setup
    {
        public IWebDriver driver = null;

        public void SetUp()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            driver = Browser.Current;
        }

        public void CleanUp()
        {
            driver.Close();
        }
    }
}