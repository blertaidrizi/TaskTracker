using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class UIList
    {
        public static void ListAll()
        {
            foreach (var task in Repository.tasks)
            {
                Console.WriteLine($"{task.Id} - {task.Description}");
            }
        }

        public static void ListInProgress()
        {
            foreach (var task in Repository.tasks)
            {
                if(task.Status=="in-progress")
                {
                    Console.WriteLine($"{task.Id} - {task.Description}");
                }
            }
        }

        public static void ListDone()
        {
            foreach(var task in Repository.tasks)
            {
                if(task.Status=="done")
                {
                    Console.WriteLine($"{task.Id} - {task.Description}");
                }
            }
        }

        public static void ListToDo()
        {
            foreach (var task in Repository.tasks)
            {
                if (task.Status == "todo")
                {
                    Console.WriteLine($"{task.Id} - {task.Description}");
                }
            }
        }
    }
}
