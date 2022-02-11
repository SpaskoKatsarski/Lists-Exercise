using System;
using System.Collections.Generic;

namespace T03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            List<string> partyList = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ');
                string currentName = commandArgs[0];

                if (commandArgs[2] == "going!")
                {
                    if (!partyList.Contains(currentName))
                    {
                        partyList.Add(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is already in the list!");
                    }
                }
                else
                {
                    if (partyList.Contains(currentName))
                    {
                        partyList.Remove(currentName);
                    }
                    else
                    {
                        Console.WriteLine($"{currentName} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join('\n', partyList));
        }
    }
}
