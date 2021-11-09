using System;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {

            char ch;
            do
            {
                int x = Console.Read();     // Чтение очередного символа
                ch = Convert.ToChar(x);     // конвертирование в тип char
                if (x != 10 && x != 13)
                    Console.WriteLine(ch);  // вывод сомвола в отдельной строке
            } while (ch != 'q');

        }
    }
}
