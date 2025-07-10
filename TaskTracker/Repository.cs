using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public static class Repository
    {
        //Used for setting the index of each task and keeping track
        private static int counter = 0;

        //List of tasks
        public static List<Task> tasks = new List<Task>();

        //Method for adding a task to the task list
        public static void AddTask(string description) 
        { 
            Task task = new Task();
            task.Description = description;
            task.Id = ++counter;
            tasks.Add(task);
            SaveTo.JsonFile(tasks); //Saves the task list to a Json file
        }

        //Method for deleting a task from the task list by its index
        public static void DeleteTask(int index)
        {
            tasks.Remove(tasks.Where(t => t.Id == index).First());
            SaveTo.JsonFile(tasks);
        }

        //Method for updating a task in task list by its index
        public static void UpdateTask(int index, string modifiedDescription)
        {
            tasks.Where(t => t.Id == index).First().Description = modifiedDescription;
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now; //Because we are modifying the task we modify the property UpdatedAt as well
            SaveTo.JsonFile(tasks);
        }

        //Method for marking a task as in-progress
        public static void MarkInProgressTask(int index)
        {
            tasks.Where(t => t.Id == index).First().Status = "in-progress";
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now;
            SaveTo.JsonFile(tasks);
        }

        //Method for marking a task as done
        public static void MarkDoneTask(int index)
        {
            tasks.Where(t => t.Id == index).First().Status = "done";
            tasks.Where(t => t.Id == index).First().UpdatedAt = DateTime.Now;
            SaveTo.JsonFile(tasks);
        }
    }
}
