using System;
using System.Security.Principal;
using System.Threading.Tasks;
using TaskTracker;

//The program will continue until the user closes it
while (true)
{
    //Take the input from the user and store it in the variable input
    string input = Console.ReadLine() ?? " ";
    Console.WriteLine();

    //Take the first word from the input
    string first = input.Split(' ')[0];

    //If the first word is add, we call the AddTask method to add the task
    if (first == "add")
    {
        Repository.AddTask(input.Split('"')[1]);
        continue;
    }

    //If the first word is update, we call the UpdateTask method where we update tasks description by extracting the index from the second word in the input
    if (first == "update")
    {
        Repository.UpdateTask(int.Parse(input.Split(" ")[1]), input.Split("\"")[1]);
        continue;
    }

    //If the first word is delete, we call the DeleteTask method where we delete the task where the index is equal to the second word from the input
    if (first == "delete")
    {
        Repository.DeleteTask(int.Parse(input.Split(" ")[1]));
        continue;
    }

    //If the first word is mark-in-progress, we call the MarkInProgressTask method where we update the tasks status where the index is equal to the second word from the input
    if (first == "mark-in-progress")
    {
        Repository.MarkInProgressTask(int.Parse(input.Split(" ")[1]));
        continue;
    }

    //If the first word is mark-done, we all the MarkDoneTask method where we update the tasks status where the index is equal to the second word in the input
    if (first == "mark-done")
    {
        Repository.MarkDoneTask(int.Parse(input.Split(" ")[1]));
        continue;
    }

    //We store the second word from the input. The word might be null
    string? task;

    try
    {
         task = input.Split(" ")[1];
    }
    catch 
    {
         task = null;
    }

    //If first is list and task is null, then we call the ListAll method
    if (first == "list" && task==null)
    {
        UIList.ListAll();
        continue;
    }

    //If first is list and task is done, then we call the ListDone method
    if (first == "list" && task == "done")
    {
        UIList.ListDone();
        continue;
    }

    //If first is list and task is in-progress, then we call the ListInProgress method
    if(first == "list" && task == "in-progress")
    {
        UIList.ListInProgress();
        continue;
    }

    //If first is list and task todo, then we call the ListToDo method
    if(first == "list" && task == "todo")
    {
        UIList.ListToDo();
        continue;
    }
    else
    {
        //If none of the cases are true, we return an error message where we prompt the user to try again
        Console.WriteLine("The input was not valid, try again!");
    }
}

