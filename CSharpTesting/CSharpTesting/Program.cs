using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpTesting
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            logger.Info("Navigating to the website");
            driver.Navigate().GoToUrl("http://andreilorin.com");

            IWebElement contactButton = driver.FindElement(By.CssSelector("#contact"));

            logger.Info("Clicking Contact Button");
            contactButton.Click();

            driver.Quit();
        }
    }
}
