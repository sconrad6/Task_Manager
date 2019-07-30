using System;
using System.Collections.Generic;

namespace Task_Manager
{
    public class TaskManager
    {
         public static List<Task> taskList = new List<Task>
         {
             new Task("Mark", "Replace water filter", "08/01/2019", false),
             new Task("Joe", "Make bread", "07/30/2019", false),
             new Task("Stefan", "Vacuum the living room", "07/27/2019", false),
             new Task("LeoJohn", "Weed the garden", "08/05/2019", false),
             new Task("Ann", "Make coffee", "08/02/2019", false)
         };

        public static void ListTasks()
        {
            foreach (Task task in taskList)
            {
                Console.WriteLine(task);
            }
        }
        
        public static void AddTask(Task task)
        {
            taskList.Add(task);
        }

        public static void CompleteTask() 
        {
            int num = TaskTest.UserCompletionChoice();
            taskList[num].Completed = true;
        }

        public static void DeleteTask() 
        {
            int num = TaskTest.UserDeletionChoice();
            taskList.RemoveAt(num);
        }

        public static void DisplayOne()
        {
            int number = TaskTest.UserViewChice();
            Console.WriteLine(taskList[number - 1]);
            
        }
    }
}
