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
            List<string> list = new List<string>();
            int n;
            Console.WriteLine("Enter the size of list");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the words of list");
            for (int k = 0; k < n; k++)
            {
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("enter the word that has to be searched");
            string word = Console.ReadLine();
            list.Sort();
            int i = 0, j = n - 1;
            bool found = false;
            while (i <= j)
            {
                int mid = (i + j) / 2;
                if (list[mid].CompareTo(word) == 0)
                {
                    found = true;
                    break;
                }
                else if (list[mid].CompareTo(word) < 0)
                    i = mid + 1;
                else
                    j = mid - 1;
            }
            if (found == true)
                Console.WriteLine("Element Found");
            else
                Console.WriteLine("Element not found");
        }
    }
}