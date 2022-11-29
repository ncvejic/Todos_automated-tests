using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todos.pageobjects;
using Todos.testdata;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using Todos.support;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace Todos.tests
{
    [TestFixture]
    public class NegativeTests
    {
        private static IWebDriver driver;
        //private Utils Utils = new Utils();
        private TodosPageObject todoPage;
        private CommonPageObjects common;

        private ExtentReports extent;
        ExtentReports report;
        ExtentHtmlReporter htmlReporter;
        ExtentTest test;

        [OneTimeSetUp]
        public void setUpOnce()
        {
            htmlReporter = new ExtentHtmlReporter(@".\ExtentReportsNeg\NegativeTestsReport.html");
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.ReportName = "Test Report for NEGATIVE tests";
            htmlReporter.Config.DocumentTitle = "Test Report for NEGATIVE tests | Nada Cvejic";
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("./webdrivers");
            todoPage = new TodosPageObject(driver);
            common = new CommonPageObjects(driver);

            common.OpenApplication();
            Utils.WaitForElement(driver, todoPage.TaskInput);
        }

        [TearDown]
        public void TearDown()
        {
            common.CloseApplication();
            extent.Flush();
        }

        [Test]

        // Test case 05:  Input limitation  and Test case 06:and No empty task is allowed
        public void TcInputLimits()
        {
            test = extent.CreateTest("TC05 Input limitation  and TC06:and No empty task is allowed");

            TasksTestData.NegativeTests();           

            //todoPage.Open();
            foreach (support.TaskIn task in TasksTestData.NegativeTestList)
            {
                todoPage.PopulateTaskInput(task.GetContent());
                todoPage.PressEnter(todoPage.TaskInput);
            }
            Assert.AreEqual(TasksTestData.NegativeTestList.Count() - 1, todoPage.Count() );
        }

        [Test]

        //   Test case 07: Delete task through EDIT functionality

        public void TcDeleteViaEdit()
         
        {
            test = extent.CreateTest("TC07 Delete task through EDIT functionality");

            TasksTestData.FillTaskList();

            //todoPage.Open();
            support.TaskIn task = TasksTestData.TaskList.First();
            todoPage.PopulateTaskInput(task.GetContent());
            todoPage.PressEnter(todoPage.TaskInput);   
            todoPage.ActionDoubleClick();
            System.Threading.Thread.Sleep(1000);
            todoPage.ClearText();
            System.Threading.Thread.Sleep(2000);
            todoPage.PressEnter(todoPage.TaskInput);

            if (0 != todoPage.Count())
                test.Log(Status.Fail, "Asserting is failing, task is not deleted via EDIT");

            Assert.AreEqual( 0, todoPage.Count());
        }


        [Test]

        //Test case 08: EDIT completed task
        public void TcEditCompletedTask()
        {
            test = extent.CreateTest("TC08 Edit completed task");
            TasksTestData.FillTaskList();

            //todoPage.Open();
            foreach (support.TaskIn task in TasksTestData.TaskList)
            {
                todoPage.PopulateTaskInput(task.GetContent());
                todoPage.PressEnter(todoPage.TaskInput);
            }
            todoPage.CompleteOneTask();
            TasksTestData.EditTaskContent();
            support.TaskIn editTask = TasksTestData.EditTaskList.First();
            todoPage.ActionDoubleClick();
            todoPage.EditTaskInput(editTask.GetContent());
            todoPage.PressEnter(todoPage.TaskInput);

            Assert.IsTrue(todoPage.GetContent().Contains("2024") );
        }

       

        }
    }
