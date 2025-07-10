# Task Tracker Project
Task tracker is a project used to track and manage your tasks. I have build a simple command line interface (CLI) to track what you need to do, what you have done, and what you are currently working on. 
Below we have the description of each class, and lastly how to use the app.
The project URL: https://roadmap.sh/projects/task-tracker

## Task Class
This class is the domain model and describes the entity Task. We have 5 properties:
1. `Id`: The Index of the task
2. `Description`: The task itself
3. `Status`: The status of the task, which can be "in-progress", "done" or "todo". When the task is created the initial value of the status is "todo".
4. `CreatedAt`: The date and time when the task was created. When the task is created the initial value of the CreatedAt is the `DateTime.Now`
5. `UpdatedAt`: The date and time when the task was last modified

## Repository Class
After creating a Task Object, we need to store it somewhere. That why I have created a repository class where we have the list of tasks called `task` and methods for interacting with the list. We have 5 methods in this class:
1. `AddTask(string description)`: Method for adding a task to the task list `tasks`. In this method, we first create the task by storing the `description` in the property `Description` and then we store it in the list. In the end we store the list in the json file.
2. `DeleteTask(int index)`: Method for deleting a task from the task list based on the `Id` of the task. We check if the `Id` of the task is equal to the parameter `index`. In the end we store the list in the json file.
3. `UpdateTask(int index, string modifiedDescription)`: Method for updating a task with a new description based on the `Id` of the task. We check if the `Id ` of the task is equal to the parameter `index`, if yes then we store the `modifiedDescription` as its Description. Because we have modified the task, we also update the UpdatedAt property to the current time. In the end we store the list in the json file.
4. `MarkInProgressTask(int index)`: Method for updating the `Status` property to "in-progress" based on the `Id` of the task. We check if the `Id` of the task is equal to the parameter `index`, if yes we update the status of the task. Because we have modified the task, we update the `UpdatedAt` property of the task to current time. In the end we store the list in the json file.
5. `MarkDoneTask(int index)`: Method for updating the `Status` property to "done" based on the `Id` of the task. We check if the `Id` of the task is equal to the parameter `index`, if yes we update the status of the task. Because we have modified the task, we update the `UpdatedAt` property of the task to current time. In the end we store the list in the json file.
In this class we also have a variable `counter` of type int. We use this variable to set the `Id` of tasks and keep track of the last task we have added.

## UI List Class
To display the tasks list, I have created another class `UIList`. This class has 3 methods:
1. `ListAll()`: Method for displaying all the content of the tasks list.
2. `ListInProgress()`: Method for displaying all the tasks whose status is "in-progress"
3. `ListDone()`: Method for displaying all the tasks whose status is "done"
4. `ListToDo()`: Method for displaying all the tasks whose status is "todo"

## SaveTo Class
To store the list of tasks in a json file, I have created the class `SaveTo`. This class has two components:
1. The readonly string `_path` that stores the path to the json file
2. The method `ToJson(List<Task> data)` that stores the parameter `data` to the json file. In the method first we check if the directory of the file exists, if not it will first create it. The second thing is that we convert the `data` to json format. After that we store it in the file `Tasks.json'. The method that we have used makes sure that the file exists.

## The Final App
### Features

- Add new tasks
- Update task descriptions
- Delete tasks by index
- Mark tasks as in-progress or done
- List all tasks or filter by status

---

### How It Works

The main program continuously waits for user commands. It parses the input and calls the appropriate methods from the `Repository` or `UIList` classes.

### 🧠 Input Handling Logic:

- The first word of the input is treated as the command.
- The second part (if any) is parsed as an index or a filter type.
- In the case of `add` or `update`, the description is taken from between quotation marks (`"`).

---

### Supported Commands

| Command                         | Description                                 |
|----------------------------------|---------------------------------------------|
| `add "Task description"`         | Adds a new task                             |
| `update [index] "New desc"`      | Updates task at the specified index         |
| `delete [index]`                 | Deletes task at the specified index         |
| `mark-in-progress [index]`       | Marks task as in-progress                   |
| `mark-done [index]`              | Marks task as done                          |
| `list`                           | Lists all tasks                             |
| `list todo`                      | Lists tasks with status **ToDo**            |
| `list in-progress`               | Lists tasks that are **in-progress**        |
| `list done`                      | Lists tasks that are **done**               |

---
