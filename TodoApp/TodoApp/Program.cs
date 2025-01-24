using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do app");
            List<string> taskList = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("Enter 1 to add");
                Console.WriteLine("Enter 2 to remove");
                Console.WriteLine("Enter 3 view the list");
                Console.WriteLine("Enter e to exit");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task to add to the ");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added");

                }
                else if (option == "2")
                {

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " " + taskList[i]);
                    }


                    Console.WriteLine("Please enter the number of the task to delete");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                    Console.WriteLine("Task" + taskNumber + "deleted");
                }

                else if (option == "3")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine("Tasks" + taskList[i]);
                    }
                }

                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
