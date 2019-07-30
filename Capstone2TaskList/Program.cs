using System;
using System.Collections.Generic;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Task Manager!");
            bool go = true;
            while (go)
            {
                Console.WriteLine();
                Task.DisplayMenu();
                Console.WriteLine();
                
                int menuChoice = int.Parse(Console.ReadLine());

                if (menuChoice == 1)
                {
                    int taskCount = 1;
                    foreach (Task taskInfo in Task.taskList)
                    {
                        taskInfo.PrintTaskInfo(taskCount);
                        taskCount++;
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("Please enter new task info: ");

                    Task.AddToList();
                    
                }
                else if (menuChoice == 3)
                {
                    int taskCount2 = 1;
                    foreach (Task taskInfo in Task.taskList)
                    {
                        taskInfo.PrintTaskInfo(taskCount2);
                        taskCount2++;
                        Console.WriteLine();
                    }

                    Console.WriteLine("What task number would you like to delete?");
                    int delete = int.Parse(Console.ReadLine());
                    Console.WriteLine("Are you sure you want to delete task number " + delete + "? (y/n)");
                    string deleteConfirm = Console.ReadLine();
                    
                        if (deleteConfirm == "y")
                        {
                            Task.taskList.RemoveAt(delete - 1);
                            Console.WriteLine($"Task {delete} has been removed.");
                        }
                        else if (deleteConfirm == "n")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Please enter only a 'y' or 'n'. ");
                            Console.WriteLine("You are being returned to the main menu.");
                        }
                    
                }
                else if (menuChoice == 4)
                {
                    Task.MarkChoice();
                }
                else if(menuChoice == 5)
                {
                    Console.WriteLine("Have a great day");
                    go = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option!");
                    Console.WriteLine("You are being returned to the main menu.");
                }
            }
        }
    }
}
