using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    public class Task
    {
        //Id of the task
        public int Id { get; set; }
        //Short description of the task
        public string Description { get; set; }
        //The staus of the task (in progress, done, todo). Initially all tasks have the status todo
        public string Status { get; set; } = "todo";
        //The date and time when the task was created
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        //The date and time when the task was modified
        public DateTime UpdatedAt { get; set; }
    }
}
