using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    internal class Remainder
    {
        const int SECONDS_PER_TURN = 30;

        Random random = new Random();
        int secondsElapsed;

        float totalAmountOfTurns;
        int totalTurnsRounded;

        int secondsLeftInTurn;

        readonly string[] players;

        public Remainder()
        {
            players = new string[] { "Synith", "Zacra", "Azarlith", "Dato" };
        }
        public void RemainderExample()
        {
            RandomizeSecondsElapsed();
            FindTotalAmountOfTurns();
            WriteLinesToConsole(FindCurrentPlayersTurn());
        }
        void WritePlayerNames()
        {
            int i = 0;
            Console.WriteLine("The players are:\n");

            foreach (string player in players)
            {
                ++i;
                Console.WriteLine($"Player{i}: {player}");
            }
        }        
        void RandomizeSecondsElapsed() => secondsElapsed = random.Next(0, 3601);
        void FindTotalAmountOfTurns()
        {
            totalAmountOfTurns = (float)secondsElapsed / SECONDS_PER_TURN;
            secondsLeftInTurn = SECONDS_PER_TURN - secondsElapsed % SECONDS_PER_TURN;
            totalTurnsRounded = (int)MathF.Floor(totalAmountOfTurns);
        }
        int FindCurrentPlayersTurn() => totalTurnsRounded % players.Length;
        void WriteLinesToConsole(int playerIndex)
        {
            WritePlayerNames();
            Console.WriteLine($"Total amount of seconds in game is {secondsElapsed}s\n");
            Console.WriteLine($"With a turn length of {SECONDS_PER_TURN} seconds the exact amount of turns elapsed so far is {totalAmountOfTurns}\n");
            Console.WriteLine($"This is turn number {totalTurnsRounded + 1} with {secondsLeftInTurn}s left in the turn.\n");
            Console.WriteLine($"It is currently {players[playerIndex]}'s turn who is Player{++playerIndex}");
        }
    }
}
