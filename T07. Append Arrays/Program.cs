using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (var item in arr)
            {
                result.Add(item);
            }
            
            while (result.Contains(" "))
            {
                result.Remove(" ");
            }

            result.Reverse();

            Console.WriteLine(String.Join("", result.Where(s => !string.IsNullOrEmpty(s))));
        }
    }
}
