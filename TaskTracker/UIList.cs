using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class UIList
    {
        //Method for listing all tasks from the task list
        public static void ListAll()
        {
            foreach (var task in Repository.tasks)
            {
                Console.WriteLine($"{task.Id} - {task.Description}");
            }
        }

        //Method for listing all tasks that have the status in-progress
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

        //Method for listing all tasks that have the status done
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

        //Method for listing all tasks that have the status todo
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
