using System.ComponentModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpApp

{
    public class MySeleniumTest
    {
        [Test]
        public void Test1()
        {
            //No GUI - reduce time. 
            ChromeOptions options = new();
            options.AddArgument("--headless");

            //Create a new instance of the Chrome driver
            //Remove 'options' from code line below to run GUI.
            IWebDriver driver = new ChromeDriver(options);

            Console.WriteLine("Start testing... Please wait..");

            //Navigate to Amazon
            driver.Navigate().GoToUrl("https://www.amazon.com");
            Assert.That(driver.Title, Is.EqualTo("Amazon.com. Spend less. Smile more."));

            //Find the search text box and type in "laptop"
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys("laptop");

            //Find the search button and click it 
            IWebElement searchButton = driver.FindElement(By.Id("nav-search-submit-button"));
            searchButton.Click();

            //Find the search results element and verify it contains results
            IWebElement searchResults = driver.FindElement(By.ClassName("s-result-list"));
            Assert.IsTrue(searchResults.Displayed, "Search results are not displayed");

            //Verify correct result = 'laptop'
            IList<IWebElement> laptopLinks = searchResults.FindElements(By.CssSelector("a[href*='laptop']"));
            Assert.That(laptopLinks.Count, Is.GreaterThan(0), "No laptop products in search results");

            //Find the first search result title link and click it
            IWebElement firstResult = driver.FindElement(By.CssSelector("div[data-component-type='s-search-result'] h2 a"));
            firstResult.Click();

            //Wait for the page to load
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Get the price element
            IWebElement priceElement = driver.FindElement(By.CssSelector(".a-price-whole"));

            //Assign the price element to string variable
            string priceString = priceElement.Text;
            decimal price = decimal.Parse(priceString);

            //Assert that the laptop price is more than $100
            Assert.That(price, Is.GreaterThan(100), "Expected price is more than $100");

            //Close the browser
            driver.Quit();

            Console.WriteLine("Test has finished run.. Thanks!");
        }
    }
}