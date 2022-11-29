Test scripts are written in webdriver (version 107) with C# (framework .net 6.0). In order to run tests visual studio/code is needed.


I have choose data driven approach for tests, since it is optimal approach for multiple inputs.
The structure is following:
-pageobjects folder contains all elements and actions on page Todos
-support folder contains class TaskIn, which is needed to populate task input

Writting tests should be easy, since it is based on calling proper methods from created classes.

--NOTE--
chromedriver is included in project

If the architecture is well organised and prepared, QA Engineer should only manipulate with test data and to create tests by calling proper methods.
If there are changes within Todos page, updating of TodosPageObject class should be enaugh. This aprroach should provide easy maintenance of the tests and also reusability 
Based on created pageobject and user class, it is possible to create various number of tests.

Before run, should check testdata folder and update data if needed.


How to run tests?


1.In the Build menu, choose Build Solution (or press Ctrl + SHIFT + B).
2.If Test Explorer is not open, open it by choosing Test >  Test Explorer from the top menu bar (or press Ctrl + E, T).
3.Choose Run All to run the test (or press Ctrl + R, V) or Run selected test (highly recommended)


How to check tests report?


After running the tests, user can navigate to defined path (bin\Test\Debug\net6.0)and check test results within generated report.
