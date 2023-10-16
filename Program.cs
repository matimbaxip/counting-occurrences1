using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting_occurrences1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyOccurrences("do it now", "do")); // 1
            Console.WriteLine(HowManyOccurrences("empty", "d")); // 0
        }

        static int HowManyOccurrences(string input, string substring)
        {
            int count = 0;
            int index = input.IndexOf(substring);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + 1);
            }

            return count;
        }
    }
}
