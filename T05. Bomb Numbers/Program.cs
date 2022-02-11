using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int specialNumber = bombList[0];
            int bombPower = bombList[1];

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] == specialNumber)
                {
                    for (int j = 0; j < bombPower; j++)
                    {
                        int currentIndex = i - 1 - j;

                        if (currentIndex < 0)
                        {
                            break;
                        }

                        if (numbersList[currentIndex] == specialNumber)
                        {
                            break;
                        }

                        numbersList.RemoveAt(currentIndex);
                    }

                    for (int j = 0; j < bombPower; j++)
                    {
                        int currentIndex = i + 1 + j - bombPower;

                        if (currentIndex >= numbersList.Count && currentIndex < 0)
                        {
                            break;
                        }

                        numbersList.RemoveAt(currentIndex);
                    }

                    i = numbersList.IndexOf(specialNumber);

                    numbersList.Remove(specialNumber);
                }
            }

            Console.WriteLine(numbersList.Sum());
        }
    }
}
