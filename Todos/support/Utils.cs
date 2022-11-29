using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.support
{

 class Utils
    {
        private static TimeSpan elementLocatingTimeout = new TimeSpan(0, 0, 10);

        public static bool IsPresent(IWebDriver webdriver, By selector)
        {
            // try to find element by specified selector
            try
            {
                webdriver.FindElement(selector);
            }
            catch (NoSuchElementException e)
            {
                // if element not exist return false
                e.ToString();
                return false;
            }
            return true;
        }

        // wait for element to be present on page
        public static IWebElement WaitForElement(IWebDriver webDriver, By selector)
        {
            return WaitForElement(webDriver, selector, elementLocatingTimeout);
        }

        public static IWebElement WaitForElement(IWebDriver webDriver, By selector, TimeSpan seconds)
        {
            return new WebDriverWait(webDriver, seconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
        }

        // wait for element on page to become clickable
        public static IWebElement WaitForClickableElement(IWebDriver webDriver, By selector)
        {
            return WaitForClickableElement(webDriver, selector, elementLocatingTimeout);
        }

        public static IWebElement WaitForClickableElement(IWebDriver webDriver, By selector, TimeSpan seconds)
        {
            return new WebDriverWait(webDriver, seconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector));
        }
    }
}

