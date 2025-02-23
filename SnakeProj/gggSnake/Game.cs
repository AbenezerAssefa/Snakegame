using System;

namespace Snake
{
    class Game
    {
        public static bool PlayGame()
        {
            int screenwidth = 64;
            int screenheight = 32;
            Random randomnummer = new Random();
            int score = 5;
            int gameover = 0;
            Snake snake = new Snake(screenwidth / 2, screenheight / 2);
            Berry berry = new Berry(randomnummer, screenwidth, screenheight);
            Berry raspberry = new Berry(randomnummer, screenwidth, screenheight, true);
            DateTime tijd = DateTime.Now;
            DateTime tijd2 = DateTime.Now;
            string buttonpressed = "no";
            int speed = 500;

            Console.Clear();
            Console.WriteLine("Welcome to Snake Game!");
            Console.WriteLine("Choose Difficulty Level:");
            Console.WriteLine("(1) Easy");
            Console.WriteLine("(2) Medium");
            Console.WriteLine("(3) Hard");
            Console.Write("Select Difficulty (1/2/3): ");
            
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    speed = 500; 
                    break;
                case ConsoleKey.D2:
                    speed = 250; 
                    break;
                case ConsoleKey.D3:
                    speed = 10; 
                    break;
                default:
                    Console.WriteLine("Invalid selection. Defaulting to Easy.");
                    speed = 500;
                    break;
            }

            Console.WriteLine("\nPress any key to start the game...");
            Console.ReadKey();  

            Console.Clear(); 

            while (true)
            {
                Console.Clear();
                if (snake.CollidesWithBoundary(screenwidth, screenheight))
                {
                    gameover = 1;  
                }

                snake.DrawBorder(screenwidth, screenheight);

                if (berry.CollidesWith(snake))
                {
                    score++;
                    berry.Regenerate(screenwidth, screenheight);
                }

                if (raspberry.CollidesWith(snake))
                {
                    gameover = 1;  
                }

                snake.Draw();
                berry.Draw();
                raspberry.Draw();

                tijd = DateTime.Now;
                buttonpressed = "no";
                while (true)
                {
                    tijd2 = DateTime.Now;
                    if (tijd2.Subtract(tijd).TotalMilliseconds > speed) { break; }
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo toets = Console.ReadKey(true);
                        snake.HandleInput(toets, ref buttonpressed);
                    }
                }

                snake.Move();
                if (snake.TailCount > score)
                {
                    snake.RemoveTail();
                }

                if (gameover == 1)
                {
                    break;
                }
            }

            Console.SetCursorPosition(screenwidth / 5, screenheight / 2);
            Console.WriteLine("Game Over, Score: " + score);
            Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);
            Console.WriteLine("Would you like to retry? (Y/N)");

            ConsoleKeyInfo retryKey = Console.ReadKey(true);
            return retryKey.Key == ConsoleKey.Y;  
        }
    }
}
