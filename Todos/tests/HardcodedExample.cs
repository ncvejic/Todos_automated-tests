//using NUnit.Framework;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Todos.pageobjects;
//using Todos.testdata;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Interactions;
//using Todos.support;
//using System.Xml.Linq;
//using AventStack.ExtentReports;
//using AventStack.ExtentReports.Reporter;
//using AventStack.ExtentReports.Reporter.Configuration;
//using System.Security.Cryptography.X509Certificates;

//namespace Todos.tests
//{
//    [TestFixture]
//    public class HardcodedExample
//    {
//        private ExtentReports extent;
//        ExtentReports report;
//        ExtentHtmlReporter htmlReporter;
//        ExtentTest test;
//       // private IWebDriver seleDriver;

//        [OneTimeSetUp]
//        public void setUpOnce()
//        {
//            htmlReporter = new ExtentHtmlReporter(@"C:\extent\todosreport.html");
//            htmlReporter.Config.Theme = Theme.Dark;
//            htmlReporter.Config.ReportName = "Test Report for TODOS";
//            htmlReporter.Config.DocumentTitle= "Test Report for TODOS | Nada Cvejic";
//            extent = new ExtentReports();
//            extent.AttachReporter(htmlReporter);
           
//        }



//       [Test]
//        // Create new task
//        public void CreateTask() 
            
//        {
            
//            test = extent.CreateTest("TC01 Create new task");


//            IWebDriver driver = new ChromeDriver ("c:/webdrivers");
//            driver.Navigate().GoToUrl("https://todomvc.com/examples/angular2/");
//            System.Threading.Thread.Sleep (1000);
//            IWebElement inputField = driver.FindElement(By.CssSelector("input.new-todo"));
//            inputField.SendKeys("nada");
//            inputField.SendKeys(Keys.Enter);
//            inputField.SendKeys("nada1");
//            inputField.SendKeys(Keys.Enter);
//            inputField.SendKeys("nada2");
//            inputField.SendKeys(Keys.Enter);
//            inputField.SendKeys("nada3");
//            inputField.SendKeys(Keys.Enter);

//            driver.Close();
//            extent.Flush();
//        }

//        [Test]
//        // Edit created task
//        public void EditTask()
//        {

//            test = extent.CreateTest("TC02 Edit existing task");  

//            IWebDriver driver = new ChromeDriver("c:/webdrivers");
//            driver.Navigate().GoToUrl("https://todomvc.com/examples/angular2/");
//            System.Threading.Thread.Sleep(1000);
//            IWebElement inputField = driver.FindElement(By.CssSelector("input.new-todo"));
//            inputField.SendKeys("nada");
//            inputField.SendKeys(Keys.Enter);
//            System.Threading.Thread.Sleep(1000);

//            IWebElement clickDouble= driver.FindElement(By.TagName("label"));
            
//            Actions act = new Actions(driver);
//            System.Threading.Thread.Sleep(2000);
//            act.MoveToElement(clickDouble).DoubleClick().Perform();
//            System.Threading.Thread.Sleep(1000);
          
//            IWebElement editContent = driver.FindElement(By.CssSelector("input.edit"));
//            editContent.Click();
//            // act.MoveToElement(editField).DoubleClick().Build().Perform();
//            System.Threading.Thread.Sleep(1000);                       
//            editContent.SendKeys("nada11");
//            editContent.SendKeys(Keys.Enter);
//            driver.Close();
            
//            extent.Flush();
//        }
//        [Test]
//        // Delete created task
//        public void DeleteTask()
//        {
//            test = extent.CreateTest("TC03 Delete task from the list");

//            IWebDriver driver = new ChromeDriver("c:/webdrivers");
//            driver.Navigate().GoToUrl("https://todomvc.com/examples/angular2/");
//            System.Threading.Thread.Sleep(1000);
//            IWebElement inputField = driver.FindElement(By.CssSelector("input.new-todo"));
//            inputField.SendKeys("nada");
//            inputField.SendKeys(Keys.Enter);
//            inputField.SendKeys("nada1");
//            inputField.SendKeys(Keys.Enter);
//            IWebElement completed = driver.FindElement(By.ClassName("toggle"));
//            completed.Click();
//            IWebElement deleteT = driver.FindElement(By.ClassName("destroy"));
//            deleteT.Click();

//            driver.Close();
//            extent.Flush();

//        }

//        [Test]
//        // Complete task and clear completed
//        public void ClearTasks()
//        {


//            test = extent.CreateTest("TC04 Clear completed task"); 

//            IWebDriver driver = new ChromeDriver("c:/webdrivers");
//            driver.Navigate().GoToUrl("https://todomvc.com/examples/angular2/");
//            System.Threading.Thread.Sleep(1000);
//            IWebElement inputField = driver.FindElement(By.CssSelector("input.new-todo"));
//            inputField.SendKeys("nada");
//            inputField.SendKeys(Keys.Enter);
//            inputField.SendKeys("nada1");
//            inputField.SendKeys(Keys.Enter);
//            IWebElement completed = driver.FindElement(By.ClassName("toggle"));
//            completed.Click();
//            IWebElement clearT = driver.FindElement(By.ClassName("clear-completed"));
//            clearT.Click();
//            driver.Close();
//            extent.Flush();

//        }

//        [Test]
//        // Create empty task
//        public void CreateEmptyTask()
//        {
//            test = extent.CreateTest("TC05 Try to create empty task"); 

//            IWebDriver driver = new ChromeDriver("c:/webdrivers");
//            driver.Navigate().GoToUrl("https://todomvc.com/examples/angular2/");
//            System.Threading.Thread.Sleep(1000);
//            IWebElement inputField = driver.FindElement(By.CssSelector("input.new-todo"));
//            inputField.SendKeys("");
//            inputField.SendKeys(Keys.Enter);

//            //validate checkbox is missing
                    
//             driver.Close();
//            extent.Flush();
//        }

//    }
//    }

