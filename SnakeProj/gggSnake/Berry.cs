using System;

namespace Snake
{
    class Berry
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
        public ConsoleColor Color { get; set; }

        public Berry(Random random, int screenwidth, int screenheight, bool isRaspberry = false)
        {
            Color = isRaspberry ? ConsoleColor.Magenta : ConsoleColor.Cyan;
            Regenerate(random, screenwidth, screenheight);
        }

        public void Regenerate(Random random, int screenwidth, int screenheight)
        {
            xpos = random.Next(1, screenwidth - 2);
            ypos = random.Next(1, screenheight - 2);
        }

        public bool CollidesWith(Snake snake)
        {
            return xpos == snake.xpos && ypos == snake.ypos;
        }

        public void Draw()
        {
            Console.SetCursorPosition(xpos, ypos);
            Console.ForegroundColor = Color;
            Console.Write("■");
        }
    }
}
