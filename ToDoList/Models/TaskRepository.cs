using System;
using System.Collections.Generic;
using System.Text;


namespace ToDoList.Models
{
    public static class TaskRepository
    {
        public static List<TaskItem> task = new List<TaskItem>()
        {
            new TaskItem { Title = "Buy groceries", Detail = "Milk, Bread, Eggs" },
            new TaskItem { Title = "Call Mom", Detail = "Her birthday is coming up" },
            new TaskItem { Title = "Finish project", Detail = "Due next week" }

        };


        public static List<TaskItem> GetTask() => task;
    
        public static TaskItem GetTaskById(int id)
        {
            return task.FirstOrDefault(t => t.TaskId == id);
        }
    }
}
