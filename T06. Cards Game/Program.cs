using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string winner = string.Empty;
            int winScore = 0;

            while (true)
            {
                if (firstDeck.Count == 0)
                {
                    winner = "Second";
                    winScore = secondDeck.Sum();
                    break;
                }

                if (secondDeck.Count == 0)
                {
                    winner = "First";
                    winScore = firstDeck.Sum();
                    break;
                }

                int playerOnesCard = firstDeck[0];
                int playerTwosCard = secondDeck[0];

                if (playerTwosCard > playerOnesCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);

                    secondDeck.Add(playerOnesCard);
                    secondDeck.Add(playerTwosCard);
                }
                else if (playerOnesCard > playerTwosCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);

                    firstDeck.Add(playerTwosCard);
                    firstDeck.Add(playerOnesCard);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }

            Console.WriteLine($"{winner} player wins! Sum: {winScore}");
        }
    }
}
