namespace HelloSelenium {    
    
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using System;

    internal class Selenium {
        internal void LoadNordstromWebsite(){
            FirefoxDriverService firefoxDriverService = FirefoxDriverService.CreateDefaultService(@"resources/drivers/");
            
            using(IWebDriver webDriver = new FirefoxDriver(firefoxDriverService, new FirefoxOptions())){
                webDriver.Url = "https://www.nordstrom.com";
                Console.WriteLine("Nordstrom website successfully loaded. Closing browser ...");
            }
        }
    }
}
