using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TestAutomation.pageObject
{
    public class pageO
    {
        private IWebDriver driver = new ChromeDriver();
        public void openPage()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }
        
        
    }
}
