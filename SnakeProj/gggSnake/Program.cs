using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                gameRunning = Game.PlayGame();
            }
        }
    }
}

