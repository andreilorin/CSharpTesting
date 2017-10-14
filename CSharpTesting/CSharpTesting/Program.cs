using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSharpTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://andreilorin.com");

            IWebElement contactButton = driver.FindElement(By.CssSelector("#contact"));

            contactButton.Click();

            driver.Quit();
        }
    }
}
