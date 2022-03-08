using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            char[] charArray1 = word1.ToLower().ToCharArray();
            char[] charArray2 = word2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            word1 = new string(charArray1);
            word2 = new string(charArray2);
            if (word1 == word2)
                Console.WriteLine("Anagram Strings");
            else
                Console.WriteLine("Not Anagram Strings");
        }
    }
}