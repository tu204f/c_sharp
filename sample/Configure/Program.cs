using System;
using System.Threading;

namespace Configure
{
    class Program
    {
        static void Main(string[] args)
        {
            // меняю цвет текста на зеленый
            Console.ForegroundColor = ConsoleColor.Green;
            // следующие две строки текста будут зелеными
            Console.WriteLine("Здравстуй, Давид!");
            Console.WriteLine("Тебя приветствует матрица!");
            // меняю цвет текста на красный
            Console.ForegroundColor = ConsoleColor.Red;
            // следующие две строки текста будут красными
            Console.WriteLine("Привет, белый человек");
            Console.WriteLine("Признавайся, где народ");

            Console.ForegroundColor = ConsoleColor.White;


            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };
            foreach (ConsoleColor color in colors)
            {
                //Console.CursorLeft = (Console.BufferWidth - color.ToString().Length / 2);
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Thread.Sleep(1000);
                Console.Clear();
            }


        }
    }
}
