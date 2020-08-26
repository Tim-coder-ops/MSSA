using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace GuessMyNumberGame
{
    class ComputerGuessesNumber
    {
        public static void initiateComputerGuess()
        {
            int[] guessRange = new int[100];

            for(int i = 0; i < guessRange.Length; i++)
            {
                guessRange[i] = i + 1;
            }

            computerGuess(guessRange);
        }
        static void computerGuess( int[] array)
        {
            Console.WriteLine($"Computer: Is the number {array[(array.Length - 1) / 2]}?" );
            Console.WriteLine("Computer: Was I\n" +
                "\t1. Too High\n" +
                "\t2. Too Low\n" +
                "\t3. Correct");

            int selection = 0;
            try
            {
                selection = int.Parse(Console.ReadLine());
                if (selection < 0 || selection > 3) throw new FormatException();
            }
            catch
            {
                Console.WriteLine("Please enter 1-3 for a selection");
                computerGuess(array);

            }
            int[] newArray;

             if (selection == 2)
            {
                newArray = new int[array.Length / 2];

                int index = 0;
                for (int i = ((array.Length - 1) / 2) + 1; i < array.Length; i++)
                {
                    newArray[index] = array[i];
                    index++;
                }

                computerGuess( newArray);
            }
            else if (selection == 1)
            {
                newArray = new int[(array.Length - 1) / 2];
                int index = 0;
                for (int i = 0; i < (array.Length - 1) / 2; i++)
                {
                    newArray[index] = array[i];
                    index++;
                }

                computerGuess( newArray);
            }
            else if (selection == 3) Console.WriteLine("Computer: Dang, I'm good.");
        }
    }
}
