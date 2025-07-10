using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class Repository
    {
        private static int counter = 0;
        public static List<Task> tasks = new List<Task>();

        public static void AddTask(string description) 
        { 
            Task task = new Task();
            task.Description = description;
            task.Id = ++counter;
            tasks.Add(task);
            SaveTo.JsonFile(tasks);
        }

        public static void DeleteTask(int index)
        {
            tasks.Remove(tasks.Where(t => t.Id == index).First());
            SaveTo.JsonFile(tasks);
        }

        public static void UpdateTask(int index, string modifiedDescription)
        {
            tasks.Where(t => t.Id == index).First().Description = modifiedDescription;
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now;
            SaveTo.JsonFile(tasks);
        }
        public static void MarkInProgressTask(int index)
        {
            tasks.Where(t => t.Id == index).First().Status = "in-progress";
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now;
            SaveTo.JsonFile(tasks);
        }
        public static void MarkDoneTask(int index)
        {
            tasks.Where(t => t.Id == index).First().Status = "done";
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now;
            SaveTo.JsonFile(tasks);
        }
    }
}
