using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.Threading;

namespace SeleniumDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebDriverBasics();
            WebDriverAdvanced();
        }

        static void WebDriverBasics()
        { 
            IWebDriver driver = new ChromeDriver(@".");
            //driver.Url = "http://www.mdsol.com";
            //driver.FindElement(By.Id("search-toggle")).Click();
            //Thread.Sleep(10);
            //driver.FindElement(By.Id("edit-keyword")).SendKeys("rave");
            //driver.FindElement(By.Id("edit-submit-md-views-search")).Click();

            driver.Url = "http://www.google.com";
            var searchbox = driver.FindElement(By.Id("gbqfq"));  //searchbox is an IWebElement
            searchbox.SendKeys("pluralsight");

            //google uses ajax so k1 may not exist yet
            //this tells it to wait up to x until it fails for not finding an element, 
            // giving the browser time to render the element
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));

            var imagesLink = driver.FindElements(By.ClassName("kl"))[0]; 
            imagesLink.Click();

            var ul=driver.FindElement(By.ClassName("rg_ul"));
            var firstImage=driver.FindElements(By.TagName("a"))[0];
            firstImage.Click();

            //maybe to look to see if an element exists
            //driver.PageSource.Contains();
        }
        static void WebDriverAdvanced()
        {
            IWebDriver driver = new ChromeDriver(@".");
            driver.Url=@"D:\Projects\SeleniumDemo\SeleniumDemo\TestPage.html";
           // var  driver
        }

    }
}
