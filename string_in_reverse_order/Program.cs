using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_in_reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWords = Console.ReadLine();
            char[] userWordsRevers = userWords.ToCharArray();
            Array.Reverse(userWordsRevers);
            userWords = new string(userWordsRevers);
            Console.WriteLine(userWords);
        }
    }
}
