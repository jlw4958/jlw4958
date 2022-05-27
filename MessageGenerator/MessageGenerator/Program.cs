using System;

namespace MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphArray = new char[26];

            //populating the array
            for (int i = 97; i < 123; i++)
            {
                int num = 0;
                alphArray[num] = (char)i;
                num++;
            }

            AlphabetShuffle(alphArray, "Hello World!");
        }

        public static void AlphabetShuffle(char[] array, string word)
        {
            //all lowercase for now!
            word.ToLower();

            string finalWord = "";

            //comparing to the text
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    //look at first letter in array
                    //print letter
                    //once i equals the letter, print and move to next
                    //but, we need to keep printing the letters we find
                    //we can have a starting string and add on as we go
                    //example:
                    /*
                     * a
                     * b
                     * c
                     * d
                     * e
                     * f
                     * fa
                     * faa
                     * fab
                     * fac
                     * fad
                     * fae
                     * ^^^that's the final word
                     */

                    Console.WriteLine(finalWord + array[j]);

                    if (array[j] == word[i])
                    {
                        finalWord = finalWord + array[j];
                        continue;
                    }
                    
                }
            }
        }
    }
}

