using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class TodoApp
    {
        public List<Task> tasks;
        public int taskNumber;
        public object task;

        public TodoApp()
        {
            tasks = new List<Task>();
        }

        public void AddTask()
        {
            Console.WriteLine("Enter task title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter task description");
            string description = Console.ReadLine();
            tasks.Add(new Task{ Title = title, Description = description });
            Console.WriteLine("Task added!!");

        }

        public void ListTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available");
            }
            else
            {
                Console.WriteLine("All Tasks");
            }

            foreach (var task in tasks)
            {
                Console.WriteLine($" Title: {task.Title}");
                Console.WriteLine($" Description: {task.Description}");
            }

        }


        public void ViewTask()
        {

            Console.WriteLine("Enter the task number to view details");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0 && Number <= tasks.Count)
            {
                 Task task = tasks[Number - 1];
                Console.WriteLine($"Task Details");
                Console.WriteLine($"Title:{task.Title} ");
                Console.WriteLine($"Description:{task.Description} ");
            }
            else
            {
                Console.WriteLine("Invalid number, Try again!!");
            }

        }

        public void DeleteTask()
        {
            Console.WriteLine("Enter the task number to remove from list.");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Tasks deleted successfully!!");
            }
            else
            {
                Console.WriteLine("Invalid task number");
            }

        }



    }
}
