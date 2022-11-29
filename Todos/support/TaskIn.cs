using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.support
{
   class TaskIn
        {
            private string taskcontent;
            public TaskIn (String taskcontent)
            {
                SetContent(taskcontent);
            }
            public string GetContent()
            {
                return taskcontent;
            }

            private void SetContent(string taskcontent)
            {
                this.taskcontent = taskcontent;
            }
        }
    }


