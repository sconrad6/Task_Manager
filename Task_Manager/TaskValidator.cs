using System;
namespace Task_Manager
{
    public class TaskValidator
    {
        // validates that the user imput for complete and delete is an integer
        //between 0 and list size
        public static bool NumberValidator(string userInput) 
        {
            int number;
            try
            {
                number = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                return false;
            }

            if (number > 0 && number <= TaskManager.taskList.Count)
            {
                return true;
            }
            Console.WriteLine("Invalid number");
            return false;
        }

        // validates that the user's choice (Ie. Yes or No) in the complete and delete
        // methods are letters and are "y" or "n" and NOT any other characters or numbers 
        public static bool LetterValidator(string userInput)
        {
            if (userInput == "y" || userInput == "n")
            {
                return true;
            }
            Console.WriteLine("Invalid input");
            return false;
        }
    }
}
