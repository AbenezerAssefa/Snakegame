using System;
using System.Collections.Generic;

namespace Snake
{
    class Snake
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
        public ConsoleColor Color { get; set; }
        public string Movement { get; set; }
        public List<int> xposlijf { get; set; }
        public List<int> yposlijf { get; set; }
        public int TailCount => xposlijf.Count;

        public Snake(int startX, int startY)
        {
            xpos = startX;
            ypos = startY;
            Color = ConsoleColor.Red;
            Movement = "RIGHT";
            xposlijf = new List<int>();
            yposlijf = new List<int>();
        }

        public void Draw()
        {
            Console.SetCursorPosition(xpos, ypos);
            Console.ForegroundColor = Color;
            Console.Write("■");

            for (int i = 0; i < xposlijf.Count; i++)
            {
                Console.SetCursorPosition(xposlijf[i], yposlijf[i]);
                Console.Write("■");
            }
        }

        public void DrawBorder(int screenwidth, int screenheight)
        {
            for (int i = 0; i < screenwidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
            }
            for (int i = 0; i < screenwidth; i++)
            {
                Console.SetCursorPosition(i, screenheight - 1);
                Console.Write("■");
            }
            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }
            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(screenwidth - 1, i);
                Console.Write("■");
            }
        }

        public bool CollidesWithBoundary(int screenwidth, int screenheight)
        {
            return xpos == screenwidth - 1 || xpos == 0 || ypos == screenheight - 1 || ypos == 0;
        }

        public void HandleInput(ConsoleKeyInfo key, ref string buttonPressed)
        {
            if (key.Key.Equals(ConsoleKey.UpArrow) && Movement != "DOWN" && buttonPressed == "no")
            {
                Movement = "UP";
                buttonPressed = "yes";
            }
            if (key.Key.Equals(ConsoleKey.DownArrow) && Movement != "UP" && buttonPressed == "no")
            {
                Movement = "DOWN";
                buttonPressed = "yes";
            }
            if (key.Key.Equals(ConsoleKey.LeftArrow) && Movement != "RIGHT" && buttonPressed == "no")
            {
                Movement = "LEFT";
                buttonPressed = "yes";
            }
            if (key.Key.Equals(ConsoleKey.RightArrow) && Movement != "LEFT" && buttonPressed == "no")
            {
                Movement = "RIGHT";
                buttonPressed = "yes";
            }
        }

        public void Move()
        {
            xposlijf.Add(xpos);
            yposlijf.Add(ypos);
            switch (Movement)
            {
                case "UP": xpos--; break;
                case "DOWN": xpos++; break;
                case "LEFT": ypos--; break;
                case "RIGHT": ypos++; break;
            }
        }

        public void RemoveTail()
        {
            xposlijf.RemoveAt(0);
            yposlijf.RemoveAt(0);
        }
    }
}
