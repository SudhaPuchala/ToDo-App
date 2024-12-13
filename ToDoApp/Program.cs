using System.Threading.Channels;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isTrue = true;
            Console.WriteLine("-------WELCOME TO THE TO DO APP!!--------");
            TodoApp todoApp = new TodoApp();
           
           string command;

            do 
            {
                Console.WriteLine("Available commands");
                Console.WriteLine("1.-  Add a new task");
                Console.WriteLine("2 -  List task");
                Console.WriteLine("3 -  View task");
                Console.WriteLine("4 -  Remove task");
                Console.WriteLine("5 -  Exit");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Console.Write("Add new task : ");
                        todoApp.AddTask();
                        break;
                    case "2":
                        Console.Write("List Task");
                        todoApp.ListTask();
                        break;
                    case"3" :
                        Console.Write("View Task");
                        todoApp.ViewTask();
                        break;
                    case "4":
                        Console.Write("Remove Task");
                        todoApp.DeleteTask();
                        break;
                    case "5":
                        Console.WriteLine("Thanks for using our app");
                        break;

                    default:
                        Console.WriteLine("Invalid input,EXIT!!");
                        break;
                }
            } while (command != "exit");
            

        }
    }
}
