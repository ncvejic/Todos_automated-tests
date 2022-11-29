using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Todos.tests;
using OpenQA.Selenium.Interactions;

namespace Todos.pageobjects
{
    class TodosPageObject
    {
        private IWebDriver driver;
        private CommonPageObjects common;

        public TodosPageObject(IWebDriver driver)
        {
            this.driver = driver;
            this.common = new CommonPageObjects(this.driver);
        }


        /* list of page components */

   
        public By TaskInput = By.CssSelector("input.new-todo");
        public By CheckCompleted = By.ClassName("toggle");
        public By DeleteTask = By.ClassName("destroy");
        public By ClearCompleted = By.ClassName("clear-completed");
        public By CountItems = By.TagName("strong");
        public By ViewTask = By.TagName("label");
        public By EditingTask = By.CssSelector("input.edit");





        /* list of page actions */


        // method for open the app
        public void Open()
        {
            driver.Navigate().GoToUrl(common.ApplicationURL);
        }
        // method fro writing new task
       public void PopulateTaskInput(String taskcontent)
        {
           driver.FindElement(TaskInput).SendKeys(taskcontent);
        }

        // method for writing existing task
        public void EditTaskInput(String taskcontent)
        {
            driver.FindElement(EditingTask).SendKeys(taskcontent);
         }

        //clear text
        public void ClearText()

        {
            driver.FindElement(EditingTask).Clear();
        }
        // method for keyboard enter in wanted field
        public void PressEnter(By by)
        {
            driver.FindElement(by).SendKeys(Keys.Enter);
           
        }
        //count left items

        public int Count()
        {

            IWebElement strongElement = driver.FindElement(CountItems);
            int itemNumber = int.Parse(strongElement.GetAttribute("innerHTML"));

            return itemNumber;

        }
        // to get content of the task
        public string GetContent()
        {

            IWebElement labelElement = driver.FindElement(ViewTask);
            string  taskContent = labelElement.GetAttribute("innerHTML");

            return taskContent;

        }

        //select checkbox
        public void CompleteOneTask()
        {
            driver.FindElement(CheckCompleted).Click();
          
        }

        //clear completed tasks

        public void ClrCompltdTask()
        {
            driver.FindElement(ClearCompleted).Click();

        }
        // delete task 

        public void DltTask()
        {
            driver.FindElement(CheckCompleted).Click();

            var dltButton = driver.FindElement(DeleteTask);
            dltButton.Click();

        }



        // double click for edit

        public void ActionDoubleClick()
            
        {
         
            Actions act = new Actions(driver);
            System.Threading.Thread.Sleep(2000);
            IWebElement clickToEdit = driver.FindElement(ViewTask); 
            act.MoveToElement(clickToEdit).DoubleClick().Perform();
            System.Threading.Thread.Sleep(1000);              
            driver.FindElement(EditingTask).Click();
            System.Threading.Thread.Sleep(1000);

        }

    }
}
