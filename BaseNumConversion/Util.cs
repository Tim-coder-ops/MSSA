using System;
using System.Collections.Generic;
using System.Text;

namespace BaseNumConversion
{
    class Util
    {
        public static int dec2bin(int input)
        {
            string result = "";
            while (input > 0)
            {
                result = input % 2 + result;
                input /= 2;
            }
            return int.Parse(result);
        }
        public static int dec2oct(int input)
        {
            string result = "";
            while (input > 0)
            {
                result = input % 8 + result;
                input /= 8;
            }
            return int.Parse(result);
        }
        public static int bin2dec(int input)
        {
            double result = 0;
            int i = 0;
            while (input > 0)
            {
                result += (input % 10) * (Power(2, i));
                input /= 10;
                i++;
            }
            return (int)result;
        }
        public static int bin2oct(int input)
        {
            return dec2oct(bin2dec(input));
        }
        public static int oct2bin(int input)
        {
            return dec2bin(oct2dec(input));
        }
        public static int oct2dec(int input)
        {
            double result = 0;
            int i = 0;
            while (input > 0)
            {
                result += (input % 10) * (Power(8, i));
                input /= 10;
                i++;
            }
            return (int)result;
        }
        public static int Power(int baseNum, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
