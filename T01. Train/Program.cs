using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengerTrain = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    int givenPassengers = int.Parse(commandArgs[1]);
                    passengerTrain.Add(givenPassengers);
                }
                else
                {
                    for (int i = 0; i < passengerTrain.Count; i++)
                    {
                        if (int.Parse(commandArgs[0]) + passengerTrain[i] <= maxCapacity)
                        {
                            passengerTrain[i] += int.Parse(commandArgs[0]);
                            break;
                        } 
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", passengerTrain));
        }
    }
}
