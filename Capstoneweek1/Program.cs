using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstoneweek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to get translated into Pig Latin!");
            string sentence = Console.ReadLine();

        }

        private static string TranslateToPigLatin(string sentence)
        {
            const string vowels = "AEIOUaeio";
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }
            return string.Join(" ", pigWords);
        }
    }
}
