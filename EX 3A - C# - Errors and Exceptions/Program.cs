using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace progex01
{
    class Program
    { static int InputCheck() {
            int output = 0;
            try
            {

               output = checked (int.Parse(Console.ReadLine()));
                if (output > 0)
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("Entered number must be greater than 0");
                    return InputCheck();
                }
            }   

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid real number.");
                return InputCheck();
            }

            catch(OverflowException e)
            {
                Console.WriteLine("CHECKED AND CAUGHT; " + e.ToString());
                return InputCheck();
            }
            return output;
        }

        static void Quardratic()
        {

            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Enter side A");
            int a = InputCheck();
            Console.WriteLine("Enter side B");
            int b = InputCheck();
            Console.WriteLine("Enter side C");
            int c = InputCheck();

            int denominator = 2 * a;
            if (((b * b) - (4 * a * c)) > 0)
            {
                double sqrtPart = (b * b) - (4 * a * c);
                double positive_num = (-1 * b) + Math.Sqrt(sqrtPart);
                double negative_num = (-1 * b) - Math.Sqrt(sqrtPart);
                Console.WriteLine(positive_num);
                Console.WriteLine(negative_num);

                Console.WriteLine($"The positive solution is {positive_num / denominator}");
                Console.WriteLine($"The negative solution is {negative_num / denominator}");
            }
            else
            {
                Console.WriteLine("The input numbers will not produce a valid result as you cannot square root 0 or a negative negative number");
                Quardratic();
            }


        }
        static void Main(string[] args)
        {
            try { 
           
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            int intradius = InputCheck();
            double circumference =checked( 2 * Math.PI * intradius);
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            double area =checked (Math.PI * Math.Pow(intradius, 2));

            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius:");
            intradius = InputCheck();

            double volume = checked((4 / 3) * Math.PI * Math.Pow(intradius, 3)) / 2;

            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            int a, b, c;

            Console.WriteLine("Enter side #1");
            a =  InputCheck();
            Console.WriteLine("Enter side #2");
            b = InputCheck();
            Console.WriteLine("Enter side #3");
            c = InputCheck();
            double p = checked((a + b + c) / 2);
            area = checked( Math.Sqrt(p * (p - a) * (p - b) * (p - c)));


            Console.WriteLine($"The area is {area}");

            //Calling method for part 4
            Quardratic();

             }

            catch(OverflowException e)
            {
                Console.WriteLine("CHECKED AND CAUGHT; " + e.ToString());
            }

            finally
            {
                Console.WriteLine("This program has finally terminated");
            }

            


        }
    }
}

