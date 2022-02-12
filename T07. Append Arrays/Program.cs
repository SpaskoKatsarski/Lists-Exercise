using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> startingList = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            // 1 2 3 |4 5 6 |  7  8

            List<int> numbers = new List<int>();

            foreach (var str in startingList)
            {
                numbers.AddRange(str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
