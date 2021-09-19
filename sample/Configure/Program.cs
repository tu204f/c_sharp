using System;

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
        }
    }
}
