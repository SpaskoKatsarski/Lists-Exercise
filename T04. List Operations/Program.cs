using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commandArgs = input.Split();
                string action = commandArgs[0];
                
                if (action == "Add")
                {
                    numbers.Add(int.Parse(commandArgs[1]));
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    int count = int.Parse(commandArgs[2]);

                    if (commandArgs[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        // TODO: Finish for right 
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
