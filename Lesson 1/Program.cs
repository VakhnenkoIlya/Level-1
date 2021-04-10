using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя? ");
            string name = Console.ReadLine();

            string s = $"Привет, {name}, сегодня {DateTime.Now.ToShortDateString()}";
            Console.WriteLine(s);

        }
    }
}
