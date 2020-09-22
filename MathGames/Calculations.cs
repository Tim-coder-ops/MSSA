using System;
using System.Collections.Generic;
using System.Text;

namespace MathGames
{
    class Calculations
    {
        static Random ran = new Random();

        static int maxNum = 0;
        static int minNum = 0;

        static void generateNum()
        {
            maxNum = ran.Next(1, 12);
            minNum = ran.Next(1, 12);

            if(minNum > maxNum)
            {
                int temp = maxNum;
                maxNum = minNum;
                maxNum = temp;
            }
        }
        public static int Add(int probs)
        {
            int score = 0;
            Console.WriteLine($"You are testing Addition and you have {probs} problems.");

            for(int i =0; i < probs; i++)
            {
                generateNum();
                int answer = maxNum + minNum;
                Console.Write($"{maxNum} + {minNum} = ");
                if (int.Parse(Console.ReadLine()) == answer)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else Console.WriteLine($"Sorry, the correct answer is {answer}.");
            }

            return score;
        }

        public static int Subtract(int probs)
        {
            int score = 0;
            Console.WriteLine($"You are testing Subtraction and you have {probs} problems.");

            for (int i = 0; i < probs; i++)
            {
                generateNum();
                int answer = maxNum - minNum;
                Console.Write($"{maxNum} - {minNum} = ");
                if (int.Parse(Console.ReadLine()) == answer)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else Console.WriteLine($"Sorry, the correct answer is {answer}.");
            }

            return score;

        }
       
        public static int Multiply(int probs)
        {
            int score = 0;
            Console.WriteLine($"You are testing Multiplication and you have {probs} problems.");

            for (int i = 0; i < probs; i++)
            {
                generateNum();
                int answer = maxNum * minNum;
                Console.Write($"{maxNum} * {minNum} = ");
                if (int.Parse(Console.ReadLine()) == answer)
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else Console.WriteLine($"Sorry, the correct answer is {answer}.");
            }

            return score;

        }
       
        public static int Divide(int probs)
        {
            int score = 0;
            Console.WriteLine($"You are testing Division and you have {probs} problems.");

            for (int i = 0; i < probs; i++)
            {
                generateNum();
                double num1 = maxNum;
                double num2 = minNum;
                double answer = Math.Round( num1 / num2, 2);
                Console.Write($"{maxNum} / {minNum} = ");
                double userInput = double.Parse(Console.ReadLine());
                if ( userInput == answer || userInput == answer - 0.01 )
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                else Console.WriteLine($"Sorry, the correct answer is {answer}.");
            }

            return score;

        }

    }
}
