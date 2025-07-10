using System;
using System.Security.Principal;
using System.Threading.Tasks;
using TaskTracker;

List<string> tasks = new List<string>();

while (true)
{
    string input = Console.ReadLine() ?? " ";

    string first = input.Split(' ')[0];

    if (first == "add")
    {
        Repository.AddTask(input.Split('"')[1]);
    }

    if (first == "update")
    {
        Repository.UpdateTask(int.Parse(input.Split(" ")[1]), input.Split("\"")[1]);
    }

    if (first == "delete")
    {
        Repository.DeleteTask(int.Parse(input.Split(" ")[1]));
    }

    if (first == "mark-in-progress")
    {
        Repository.MarkInProgressTask(int.Parse(input.Split(" ")[1]));
    }

    if (first == "mark-done")
    {
        Repository.MarkDoneTask(int.Parse(input.Split(" ")[1]));
    }

    string? task;

    try
    {
         task = input.Split(" ")[1];
    }
    catch 
    {
         task = null;
    }

    if (first == "list" && task==null)
    {
        UIList.ListAll();
    }

    if (first == "list" && task == "done")
    {
        UIList.ListDone();
    }

    if(first == "list" && task == "in-progress")
    {
        UIList.ListInProgress();
    }

    if(first == "list" && task == "todo")
    {
        UIList.ListToDo();
    }

    Console.WriteLine();
}

