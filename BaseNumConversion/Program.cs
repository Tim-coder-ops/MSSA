using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace BaseNumConversion
{
    class Program
    {
        public static void play()
        {
            Console.WriteLine("Please enter the integer to convert: ");
            string n1 = Console.ReadLine();
            int number = int.Parse(n1);

            Console.WriteLine("Please enter the base to convert from [2 | 8 | 10]: ");
            string n2 = Console.ReadLine();
            int from = int.Parse(n2);

            Console.WriteLine($"Number: {number}, base: {from}");
            int result = 0;
            if (from == 10)
            {
                result = Util.dec2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = Util.dec2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 2)
            {
                result = Util.bin2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
                result = Util.bin2oct(number);
                Console.WriteLine($"octal conversion is {result}");
            }
            else if (from == 8)
            {
                result = Util.oct2bin(number);
                Console.WriteLine($"binary conversion is {result}");
                result = Util.oct2dec(number);
                Console.WriteLine($"decimal conversion is {result}");
            }
            else
            {
                Console.WriteLine("Error in base to convert from");
            }
            play();
        }
        static void Main(string[] args)
        {
            play();

        }
    }
}
