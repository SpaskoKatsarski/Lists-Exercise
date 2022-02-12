using System;
using System.Collections.Generic;
using System.Linq;

namespace T05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            // numbers = [1, 2, 5, 3, 2]
            // bombInfo = [5, 2]

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            while (true)
            {
                int bombIndex = numbers.IndexOf(bombNumber);

                if (bombIndex == -1)
                {
                    //There are no more bombs inside the list
                    break;
                }

                DetonateBomb(numbers, bombIndex, bombPower);
            }

            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int bombIndex, int bombPower)
        {
            //TODO: Make a variable for the rightCount

            int rightCount = bombIndex + bombPower;

            for (int i = bombIndex; i <= rightCount; i++)
            {
                if (bombIndex >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(bombIndex);
            }

            //Delete elements on the left side of the bomb: 
            int leftIndex = bombIndex - bombPower;

            // Lets say that leftIndex = -2

            if (leftIndex < 0)
            {
                leftIndex = 0;
            }

            // After the if statement leftIndex will be 0
            
            for (int i = leftIndex; i < bombIndex; i++)
            {
                numbers.RemoveAt(leftIndex);
            }
        }
    }
}
