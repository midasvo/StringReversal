using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> reversedSentenceList = ReverseSentence(args);

            // Use space as a delimiter.
            string reversedSentence = String.Join(" ", reversedSentenceList);
            Console.WriteLine(reversedSentence);
        }

        // Loops over the arguments, reversing them and adding them to a list.
        // Does not handle periods and capitalization yet.
        static List<string> ReverseSentence(string[] words)
        {
            List<string> reversedSentenceList = new List<string>();
     
            foreach (string word in words)
            {
                string reversedWord = ReverseWord(word);
                reversedSentenceList.Add(reversedWord);
            }
            return reversedSentenceList;
        }

        // Reverses the order of characters in a word and returns as a string.
        static private string ReverseWord(string str)
        {
            Console.WriteLine("Reversing the word: {0}", str);
            char[] word = str.ToCharArray();
            Array.Reverse(word);
            string reversed = new string(word);
            return reversed;
        }
    }
}
