using System;

namespace EncryptingAndDecrypting
{
    class Program
    {
        static void initialize()
        {
            string plainText = "";
            string singleKey;
            string multiKey = "";
            int[] contKey;

            Console.Write("Enter plain text:");
            plainText = Console.ReadLine();
            Console.Write("Enter your single key as an alpha character:");
            singleKey = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your multi key as alpha characters:");
            multiKey = Console.ReadLine();
            contKey = Util.GetContKey(multiKey, plainText);

            Console.WriteLine($"\nYou entered [{plainText}] as plain text");
            Console.WriteLine($"you entered [{singleKey}] as your single key");
            Console.WriteLine($"You entered [{multiKey}] as your multi key\n");

            string singEncrypted = Util.SimpleEncryption(singleKey, plainText);
            string multiEncrypted = Util.MultiEncryption(multiKey, plainText);
            string contEncrypted = Util.ContEncryption(contKey, plainText);
            Console.WriteLine($"Encrypted message with single key is[{singEncrypted}]");
            Console.WriteLine($"Encrypted message with multi key is[{multiEncrypted}]");
            Console.WriteLine($"Encrypted message with continuous key is[{contEncrypted}]\n");

            Console.WriteLine($"Decrypted message with single key is[{Util.SimpleDecryption(singleKey, singEncrypted)}]");
            Console.WriteLine($"Decrypted message with multi key is[{Util.MultiDecryption(multiKey, multiEncrypted)}]");
            Console.WriteLine($"Decrypted message with continuous key is[{Util.ContDecryption(contKey, contEncrypted)}]");

        }
        static void Main(string[] args)
        {
            initialize();
        }
    }
}
