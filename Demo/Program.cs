using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Ivan",
                "Pesho",
                "Go6o"
            };

            names.Insert(1, "Yoana");

            Console.WriteLine(names.Remove("Go6o"));

            Console.WriteLine(names.Count);

            string name = Console.ReadLine();

            Console.WriteLine($"Contains -> {names.Contains(name)}");

            Console.WriteLine(string.Join(", ", names));
        }
    }
}
