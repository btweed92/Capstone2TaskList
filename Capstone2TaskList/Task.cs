using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone2TaskList
{
    class Task
    {
        #region Lists
        public static List<Task> taskList = new List<Task>
            {
                new Task("Brandyn", "Eat ass", "07/30/2019", false),
                new Task("Josh", "Mow the lawn", "07/30/2019", false),
                new Task("Joe", "Brandyn is smrt", "07/30/2019", false)

            };
        
        #endregion
        #region Fields

        private string TMName;
        private string TaskDescription;
        private string DueDate;
        private bool Completed;

        #endregion

        #region Constructors

        public Task()
        {
            TMName = "Please enter valid information.";
            TaskDescription = "Please enter valid information.";
            DueDate = "Pleae enter valid information";
            Completed = false;
        }
        public Task(string _tmName, string _taskDescription, string _dueDate, bool _completed)
        {
            TMName = _tmName;
            TaskDescription = _taskDescription;
            DueDate = _dueDate;
            Completed = _completed;
        }

        #endregion

        #region Methods

        public bool IsCompleted(string completed)
        {
            if(completed == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("\t1. List tasks");
            Console.WriteLine("\t2. Add task");
            Console.WriteLine("\t3. Delete task");
            Console.WriteLine("\t4. Mark task complete");
            Console.WriteLine("\t5. Quit");
            Console.WriteLine("==================================");
            Console.WriteLine("What would you like to do?");
        }

        public void PrintTaskInfo(int count)
        {
            Console.WriteLine(count + ". Team Member Name: " + TMName);
            Console.WriteLine("\tTask Description: " + TaskDescription);
            Console.WriteLine("\tDue Date: " + DueDate);
            Console.WriteLine("\tComepleted: " + Completed);
        }

        public static void AddToList()
        {
            Task taskList1 = new Task();

            Console.WriteLine("Please enter a name: ");
            taskList1.TMName = Console.ReadLine();

            Console.WriteLine("Please enter a task description: ");
            taskList1.TaskDescription = Console.ReadLine();

            Console.WriteLine("Please enter a due date: ");
            taskList1.DueDate = Console.ReadLine();

            Console.WriteLine("Is the task completed yet (y/n): ");
            string isCompleted = Console.ReadLine().ToLower();
            
                if (isCompleted == "y")
                {
                    taskList1.Completed = true;
                }
                else if (isCompleted == "n")
                {
                    taskList1.Completed = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response. (y/n)");
                    
                }
            
            taskList.Add(taskList1);

        }
        public static void MarkChoice()
        {
            Console.WriteLine("Which task would you like to mark as complete?");
            Console.WriteLine();

            int taskCount = 1;
            foreach (Task taskInfo in Task.taskList)
            {
                taskInfo.PrintTaskInfo(taskCount);
                taskCount++;
                Console.WriteLine();
            }


            int userInput = int.Parse(Console.ReadLine());
            userInput--;

            Console.WriteLine("Are you sure you want to change this?(y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                taskList[userInput].Completed = true;
            }
            else
            {

            }
        }
        

        


        #endregion
    }
}
