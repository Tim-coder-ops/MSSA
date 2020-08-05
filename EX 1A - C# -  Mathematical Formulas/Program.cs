using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace progex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            // Partially worked example
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.Write("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");

            // Implementation for area here
            double area = Math.PI * Math.Pow(intradius,2);

            Console.WriteLine($"The area is {area}");


            // Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius:");
            strradius = Console.ReadLine();
            intradius = int.Parse(strradius);

            double volume = ((4 / 3) * Math.PI * Math.Pow(intradius, 3)) / 2;

            Console.WriteLine($"The volume is {volume}");


            // Part 3
            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");

            // Implementation here
            int a, b, c;

            Console.WriteLine("Enter side #1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side #2");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side #3");
            c = int.Parse(Console.ReadLine());
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            Console.WriteLine($"The area is {area}");


            // Part 4
            Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine("Enter side A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C");
            c = int.Parse(Console.ReadLine());

            int denominator = 2 * a;
            double sqrtPart = (b * b) - (4 * a * c);
            double positive_num = (-1 * b) + Math.Sqrt(sqrtPart);
            double negative_num = (-1 * b) - Math.Sqrt(sqrtPart);
            Console.WriteLine(positive_num);
            Console.WriteLine(negative_num);

            // Implementation here

             Console.WriteLine($"The positive solution is {positive_num / denominator}");
            Console.WriteLine($"The negative solution is {negative_num / denominator}");
        }
    }
}

