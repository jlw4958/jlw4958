using System;
using System.Globalization;

namespace MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphArray = new char[95];

            //number for populating the array
            int num = 0;

            //populating the array with letters, numbers, and symbols
            for (int i = 32; i < 126; i++)
            {
                alphArray[num] = (char)i;
                num++;
            }

            AlphabetShuffle(alphArray, "Hello World!");
        }

        public static void AlphabetShuffle(char[] array, string word)
        {
            ////all lowercase for now!
            //word = word.ToLower();

            string finalWord = "";

            //comparing to the text
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == )
                    {

                    }
                    Console.WriteLine(finalWord + array[j]);

                    if (array[j] == word[i])
                    {
                        finalWord += array[j];
                        break;
                    }
                    
                }
            }
        }
    }
}

