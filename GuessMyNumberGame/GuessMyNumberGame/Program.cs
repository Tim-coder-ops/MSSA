using System;
using System.Transactions;

namespace GuessMyNumberGame
{
    class Program
    {    
        static void userSelection()
        {
            Console.WriteLine("\nWhat would you like to do?\n" +
                "\t1. 1-10 bisection search\n" +
                "\t2. Human guessing a number\n" +
                "\t3. Computer guesses number");
            try
            {
                int selection = int.Parse(Console.ReadLine());
                if (selection < 1 || selection > 3) throw new FormatException();

                if (selection == 1) BisectionSearch.initiateBiSearch();
                else if (selection == 2) HumanGuessNumber.userNumGuess();
                else if (selection == 3) ComputerGuessesNumber.initiateComputerGuess();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter 1-3 for a selection");
                userSelection();
            }
            userSelection();
        }
        
        static void Main(string[] args)
        {
            
            userSelection();

            
        }
    }
}
