using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GuessMyNumberGame
{
    class HumanGuessNumber
    {
        public static void userNumGuess()
        {
            int userGuess = 0;
            Random random = new Random();
            int computerNumber = random.Next(1, 1001);
            try
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                userGuess = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a whole number between 1 and 1000");
                userNumGuess();
            }
            numbercompare(computerNumber, userGuess);

        }
        static void numbercompare(int compNum, int userGuess)
        {
            if (compNum == userGuess) Console.WriteLine("You guessed right!");
            else if(userGuess > compNum)
            {
                Console.WriteLine("Your guess was too high");
                Console.WriteLine("Enter a new guess");
                userGuess = int.Parse(Console.ReadLine());
                numbercompare(compNum, userGuess);
            }
            else if (userGuess < compNum)
            {
                Console.WriteLine("Your guess was too low");
                Console.WriteLine("Enter a new guess");
                userGuess = int.Parse(Console.ReadLine());
                numbercompare(compNum, userGuess);
            }

        }



    }
}
