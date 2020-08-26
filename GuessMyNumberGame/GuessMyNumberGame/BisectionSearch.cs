using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumberGame
{
    class BisectionSearch
    {
        //Method that calls the Bisection algorithm
        public static void initiateBiSearch()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            try
            {
                Console.WriteLine("Enter a number between 1 and 10 (integers only)");
                int num = int.Parse(Console.ReadLine());

                if (num > 0 && num < 11) bisectionSearch(num, array);
                else throw new FormatException();
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer between 1 and 10");
                initiateBiSearch();
            }


        }
        //Bisection algorithm 
        static void bisectionSearch(int number, int[] array)
        {
            int[] newArray;
            if (number == array[(array.Length - 1) / 2])
            {
                Console.WriteLine($" The " +
               $"computer says your number was {number}\n");
            }

            else if (number > array[(array.Length - 1) / 2])
            {
                newArray = new int[array.Length / 2];

                int index = 0;
                for (int i = ((array.Length - 1) / 2) + 1; i < array.Length; i++)
                {
                    newArray[index] = array[i];
                    index++;
                }

                Console.WriteLine($"The new array is {string.Join(", ", newArray)} since {number} is greater " +
                    $"than the {array[(array.Length - 1) / 2]} ");

                bisectionSearch(number, newArray);
            }
            else if (number < array[(array.Length - 1) / 2])
            {
                newArray = new int[(array.Length - 1) / 2];
                int index = 0;
                for (int i = 0; i < (array.Length - 1) / 2; i++)
                {
                    newArray[index] = array[i];
                    index++;
                }

                Console.WriteLine($"The new array is {string.Join(", ", newArray)} since {number} is less than  " +
                    $"than the {array[(array.Length - 1) / 2]}");

                bisectionSearch(number, newArray);

            }
        }
    }
}
