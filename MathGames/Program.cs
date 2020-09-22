using System;
using System.Transactions;

namespace MathGames
{
    class Program
    {
        static int selection = 0;
        static int numOfProblems = 0;
        static int numOfCorrect = 0;

        static void initialize(int selection)
        {
            try
            {
                Console.Write("Enter number of problems between 1 and 12:");
                numOfProblems = int.Parse(Console.ReadLine());
                if (numOfProblems < 1 || numOfProblems > 12)
                {
                    throw new FormatException();
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid selection");
                initialize(selection);
            }

            if (selection == 1) numOfCorrect = Calculations.Add(numOfProblems);
            else if (selection == 2) numOfCorrect = Calculations.Subtract(numOfProblems);
            else if (selection == 3) numOfCorrect = Calculations.Multiply(numOfProblems);
            else if (selection == 4) numOfCorrect = Calculations.Divide(numOfProblems);
        }

        static int welcome()
        {
           

            Console.WriteLine("\nWelcome to Math Games");
            Console.Write("\tTo add, enter 1,\n" +
                "\tTo subtract, enter 2,\n" +
                "\tTo multiply, enter 3,\n" +
                "\tTo divide, enter 4.\n" +
                "Choose your problem type:");
            try
            {
                selection = int.Parse(Console.ReadLine());
                if (selection < 1 || selection > 4)
                {
                    Console.WriteLine("Please enter a valid selection");
                    welcome();
                }

            }

            catch
            {
                Console.WriteLine("Please enter only integers");
                welcome();
            }

            return selection;
        }

        static string report(int correct, int problems)
        {
            double numCorrect = correct;
            double outOf = problems;
            double percentage = Math.Round((numCorrect / outOf) *100,0);
            return$" You got {correct} out of {problems} correct and your grade is {percentage}%";
        }
        static void Main(string[] args)
        {
            
            initialize(welcome());
            Console.WriteLine(report(numOfCorrect,numOfProblems));
        }
    }
}
