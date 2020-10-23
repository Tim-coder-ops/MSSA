using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EX7ACSV
{
    class Program
    {

        public static List<string> getCSV(string input)
        {
            List<string> result = new List<string>();
            string[] words = input.Split("\"");
            StringBuilder temp = new StringBuilder();

            for (int i = 1; i < words.Length; i++)
            {
                string word = words[i];
                

                for (int j = 0; j < word.Length; j++)
                {

                    if (j > 0 && word[j] == ',' && word[j - 1] == 'N')
                    {
                        result.Add(temp.ToString());
                        temp.Clear();
                        j++;
                    }

                    if (j == 0 && word[j] == ',' || j == word.Length - 1 && word[j] == ',') temp =temp;
                    else temp.Append(word[j]);

                    
                }

                if(temp.Length != 0 )result.Add(temp.ToString());
                temp.Clear();
            }

            return result;

        }

        public static void ReadFile()
        {
            List<string> lines = new List<string>();
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\Users\\Timwe\\OneDrive\\Documents\\MSSA\\MSSA\\EX7ACSV\\pres-test.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                        Console.WriteLine($"Current input is {line}");
                        List<string> output = getCSV(line);
                        int len = output.Count;
                        Console.WriteLine($"This line has {len-2} fields. They are:");
                        foreach (string s1 in output)
                            Console.WriteLine(s1);
                 
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            
        }
        static void Main(string[] args)
        {
            /*************************
            * read CSV with embedded commas
            * parse CSV into separate fields and
            * ignore commas within quoted string
            * ***********************/



            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
            "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
            "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);

            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                    Console.WriteLine(s1);
            }

            ReadFile();
        }
    }
}
