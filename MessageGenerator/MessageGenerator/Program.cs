using System;

namespace MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphArray = new char[58];

            //number for populating the array
            int num = 0;

            //populating the array with letters (lowercase only)
            for (int i = 97; i < 123; i++)
            {
                alphArray[num] = (char)i;
                num++;
            }

            //populating the array with punctuation and the space
            for (int i = 32; i < 64; i++)
            {
                alphArray[num] = (char)i;
                num++;
            }

            AlphabetShuffle(alphArray, "Hello World!");
        }

        public static void AlphabetShuffle(char[] array, string word)
        {
            //all lowercase for now!
            word = word.ToLower();

            string finalWord = "";

            //comparing to the text
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.WriteLine(finalWord + array[j]);

                    if (array[j] == word[i])
                    {
                        finalWord += array[j];
                        break;
                    }

                    //if (word[i] == ' ')
                    //{
                    //    finalWord += ' ';
                    //    break;
                    //}
                }
            }
        }
    }
}

