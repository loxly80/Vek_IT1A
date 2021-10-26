using System;

namespace Vek_IT1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Frame(10,10,"hello world");
            Frame(10, 15, "pokus");
            Frame(2, 2, "další rámeček");
            Console.ReadLine();
        }


        static void FrameBorder(
              int left
            , int top
            , int width
            , int height
            , ConsoleColor lineColor
            , ConsoleColor backColor
            , ConsoleColor innerColor)
        {

        }

        static void Frame(int left, int top,string text)
        {
            Console.SetCursorPosition(left, top);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("╔══════════════════════╗");
            Console.SetCursorPosition(left, top + 1);
            Console.Write("║");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("                      ");            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("║");
            Console.SetCursorPosition(left, top + 2);
            Console.Write("╚══════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(left + 1, top + 1);
            Console.Write(text);
        }
    }
}
