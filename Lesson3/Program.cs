using System;
namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задние 1");

            int[,] Array =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (i == j)

                        Console.Write($"{Array[i, j]}");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Задание 2");
            Console.WriteLine("Телефонный справочник");
            object[,] mass =
            {
                {456545, "Ivanov"},
                {659878, "Petrov"},
                {321245, "Sidorov"},
                {789878, "Vasya"},
                {654598, "Luba" }
            };
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j <  mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите приветствие");

            string m = Console.ReadLine();

            for (int i = m.Length - 1; i >= 0; i--)
            {
                Console.Write($"{m[i]}");
            }
            Console.WriteLine();






            Console.WriteLine("Задание 4");
            string[,] sea =
            {
                {"X", "X", "O", "X", "O", "O", "X", "X", "X", "X"},
                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "X"},
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "X"},
                {"O", "X", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "X", "O", "O", "O", "O", "X", "O", "O", "O"},
                {"O", "X", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O"},
                {"O", "O", "O", "X", "O", "X", "O", "O", "X", "O"},
                {"X", "O", "O", "O", "O", "O", "O", "O", "X", "O"}

            };
            for (int i = 0; i < sea.GetLength(0); i++)
            {
                for (int j = 0; j <  sea.GetLength(1); j++)
                {
                 

                        Console.Write($"{sea[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 5");

            var int_5 = 3;

            char [] massive = { '1', '2', '3', '4' };

            Console.WriteLine($"Массив:{new string (massive)}, сдвиг:{int_5}");

            var cycle_tru_num = Math.Abs(int_5) % massive.Length;
            var isnegative = Math.Sign(int_5) < 0;

            for (int i = 0; i < cycle_tru_num; i++)
            {
                var temp_element = isnegative ? massive[massive.Length - 1] : massive[0];
                if (isnegative)
                {
                    for (int j = massive.Length - 1; j > 0; j--)
                    {
                        var temp = massive[j - 1];
                        massive[j - 1] = temp_element;
                        temp_element = temp;
                    }
                    massive[massive.Length - 1] = temp_element;
                }
                else
                {
                    for (int j = 0; j < massive.Length - 1; j++)
                    {
                        var temp = massive[j + 1];
                        massive[j + 1] = temp_element;
                        temp_element = temp;
                    }
                    massive[0] = temp_element;
                }


                Console.WriteLine($"Сдвинутый массив:{new string(massive)}");
                Console.ReadLine();
            }
        }
    }
}
