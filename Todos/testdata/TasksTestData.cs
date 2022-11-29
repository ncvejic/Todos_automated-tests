using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.testdata
{
    class TasksTestData
    {
        public static List<support.TaskIn> TaskList = new List<support.TaskIn>();

        public static List<support.TaskIn> EditTaskList = new List<support.TaskIn>();

        public static List<support.TaskIn> NegativeTestList = new List<support.TaskIn>();

        public static void FillTaskList()
        {
            TaskList.Clear();
            TaskList.Add(new support.TaskIn("This is wish list for 2023 : wish 1!"));
            TaskList.Add(new support.TaskIn("This is wish list for 2023 : wish 2"));
         // TaskList.Add(new support.TaskIn("This is wish list for 2023 : wish 3"));
         // TaskList.Add(new support.TaskIn("This is wish list for 2023 : wish 4"));
           // TaskList.Add(new support.TaskIn("This is wish list for 2023 : wish 5"));
        }

        public static void EditTaskContent()
        {
            EditTaskList.Clear();
            EditTaskList.Add(new support.TaskIn("This is updated wish list for 2024 : wish 1"));
            EditTaskList.Add(new support.TaskIn("This is updated wish list for 2024 : wish 2"));
            // EditTaskList.Add(new support.TaskIn("This is updated wish list for 2023 : wish 3"));
            // EditTaskList.Add(new support.TaskIn("This is updated wish list for 2023 : wish 4"));
            // EditTaskList.Add(new support.TaskIn("This is updated wish list for 2023 : wish 5"));
        }

        public static void NegativeTests()
        {
            NegativeTestList.Clear();
            NegativeTestList.Add(new support.TaskIn(""));
            NegativeTestList.Add(new support.TaskIn("{}::I*:$#$%^#@!"));     
        }

    }
}
