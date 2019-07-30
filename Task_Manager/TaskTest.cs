using System;

namespace Task_Manager
{
    class TaskTest
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.WriteLine("\n");
            }
        }

        public static void Menu()
        {
            Console.WriteLine("What would you like to do? Type:\n" +
                $"\"List\" to list the tasks\n" +
                $"\"Add\" to add a task to the list\n" +
                $"\"Complete\" to mark a task as complete\n" +
                $"\"Delete\" to delete a task\n" +
                $"\"Exit\" to exit");
            string userChoice = Console.ReadLine().ToLower();

            switch (userChoice)
            {
                case "list":
                    Console.WriteLine("\n");
                    ListTask();
                    break;
                case "add":
                    AddUserTask();
                    break;
                case "complete":
                    TaskManager.CompleteTask();
                    break;
                case "delete":
                    TaskManager.DeleteTask();
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }
        }
        public static void ListTask()
        {
            int count = 1;
            foreach (Task t in TaskManager.taskList)
            {
                Console.WriteLine($"{count}. \n{t}");
                count++;
            }
        }

        public static void AddUserTask()
        {
            Console.WriteLine("Name:");
            string userName = Console.ReadLine();

            Console.WriteLine("Task Description:");
            string userDescription = Console.ReadLine();

            Console.WriteLine("Due Date:");
            string userDueDate = Console.ReadLine();

            Task userTask = new Task(userName, userDescription, userDueDate, false);
            TaskManager.AddTask(userTask);

            Console.WriteLine($"Task \"{userDescription}\" has been added to the list");
        }

        public static int UserDeletionChoice() 
        {
            Console.WriteLine("Which task would you like to delete?");
            string userInput;
            do
            {
                userInput = Console.ReadLine();

            } while (!TaskValidator.NumberValidator(userInput));

            int userNumber = int.Parse(userInput) - 1;
            do
            {
                Task userTask = TaskManager.taskList[userNumber];
                Console.WriteLine($"Are you sure you want to delete\n {userTask}\nY/N?");
                userInput = Console.ReadLine().ToLower();
            } while (!TaskValidator.LetterValidator(userInput));

            return userNumber;
        }

        public static int UserCompletionChoice() 
        {
            Console.WriteLine("Which task would you like to mark as complete?");
            string userInput;
            do
            {
                userInput = Console.ReadLine();

            } while (!TaskValidator.NumberValidator(userInput));

            int userNumber = int.Parse(userInput) - 1;
            do
            {
                Task userTask = TaskManager.taskList[userNumber];
                Console.WriteLine($"Are you sure you want to complete\n{userTask} \nY/N?");
                userInput = Console.ReadLine().ToLower();
            } while (!TaskValidator.LetterValidator(userInput));

            return userNumber;
        }
    }
}
