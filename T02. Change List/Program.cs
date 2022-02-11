using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArgs = input.Split();

                if (commandArgs[0] == "Delete")
                {
                    int numberToDelete = int.Parse(commandArgs[1]);
                    numbers.Remove(numberToDelete);

                    while (numbers.Contains(numberToDelete))
                    {
                        numbers.Remove(numberToDelete);
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    int numberToInsert = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    numbers.Insert(index, numberToInsert);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
