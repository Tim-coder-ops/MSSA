using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptingAndDecrypting
{
    class Util
    {
        public static string clean(string word)
        {
            word = word.ToUpper();
            string cleanedWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                int temp = word[i];

                if (temp > 64 && temp < 91)
                {
                    cleanedWord += (char)temp;
                }
            }

            return cleanedWord;
        }
        public static string SimpleEncryption(string key, string word)
        {
            key = clean(key);
            word = clean(word);
            int numKey = (int)key[0] - 64;
            string result = "";


            for(int i = 0; i < word.Length; i++)
            {
                    result += (Char)(word[i] + numKey);
            }

            return result;
        } 

        public static string SimpleDecryption(string key, string word)
        {
            key = clean(key);
            int numKey = (int)key[0] - 64;
            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                result += (Char)((int)word[i] - numKey);
            }

            return result;
        }

        public static string MultiDecryption(string key, string word)
        {
            string result = "";
            key = clean(key);
            word = clean(word);
            int[] numKey = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                numKey[i] = (int)key[i] - 64;
            }

            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (index == numKey.Length) index = 0;
                result += (Char)((int)word[i] - numKey[index]);
                index++;
            }

            return result;
        }

        public static string MultiEncryption(string key, string word)
        {
            string result = "";
            key = clean(key);
            word = clean(word);
            int[] numKey = new int[key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                numKey[i] = (int)key[i] - 64;
            }

            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                    if (index == numKey.Length) index = 0;

                    if((int)word[i] + numKey[index] > 90)
                    {
                    result += (Char)((int)word[i] + numKey[index] -26);
                    }

                    else result += (Char)((int)word[i] + numKey[index]);
                    index++;
            }

            return result;
        }

        public static int[] GetContKey(string key, string word)
        {
            key = clean(key);
            word = clean(word);
            int[] numKey = new int[word.Length];

            for (int i = 0; i < key.Length; i++)
            {
                numKey[i] = (int)key[i] - 64;
            }

            for (int i = key.Length; i < word.Length; i++)
            {
                numKey[i] = (int)word[i - key.Length] - 64;
            }

            return numKey;
        }
        public static string ContEncryption(int[] numKey, string word)
        {
            string result = "";
            word = clean(word);
            

            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (index == numKey.Length) index = 0;

                if ((int)word[i] + numKey[index] > 90)
                {
                    result += (Char)((int)word[i] + numKey[index] - 26);
                }

                else result += (Char)((int)word[i] + numKey[index]);
                index++;
            }


            return result;
        }

        public static string ContDecryption(int[] numKey, string word)
        {
            string result = "";

            for (int i = 0; i < word.Length; i++)
            { 
                if((int)word[i] - numKey[i] < 65) result += (Char)((int)word[i] - numKey[i] + 26);
                else result += (Char)((int)word[i] - numKey[i]);
            }

            return result;
        }
    }
}
