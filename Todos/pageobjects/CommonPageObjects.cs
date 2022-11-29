using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.pageobjects
{
    public class CommonPageObjects
    {
        private IWebDriver driver;

        public CommonPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        //list of page components

        public string ApplicationURL = "https://todomvc.com/examples/angular2/";

        public By PageTitle = By.CssSelector("h1");

        // list of page actions 
        public void OpenApplication()
        {
            driver.Navigate().GoToUrl(ApplicationURL);
            System.Threading.Thread.Sleep(2000);
        }

        public void CloseApplication()
        {
            driver.Quit();
        }
    }
}
