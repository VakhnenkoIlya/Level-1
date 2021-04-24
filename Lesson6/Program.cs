using System;
using System.Diagnostics;


namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: консольное приложение Task manager \n введите команду \n показать процессы show \n завершить процесс по id byid \n завершить процесс по имени byname \n выход exit ");

            do
            {
                Console.WriteLine("введите команду");

            }
            while (Accept(Console.ReadLine()));

            Console.WriteLine("Задание 2");
            int sum = 0;
            Random random = new Random();
            string[,] sArray = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sArray[i, j] = random.Next(1, 50).ToString();
                }
               
            }
            try
            {
                sum = sumArray(sArray);
            }
            catch (MyArraySizeExeption e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (MyArrayDataExeption e)
            {
                Console.WriteLine(e.StackTrace);

            }
            Console.WriteLine(sum);
        }

        public static int sumArray(string[,] sArray) //метод для задания 2
        {
            int sum = 0;
            if (sArray.GetLength(0) != 4 || sArray.GetLength(1) != 4) throw new MyArraySizeExeption();

            for (int i = 0; i < sArray.GetLength(0); i++)
            {
                for (int j = 0; j < sArray.GetLength(1); j++)
                {
                    try
                    {
                        sum += int.Parse(sArray[i, j]);
                    }
                    catch(Exception e)
                    {
                        throw new MyArrayDataExeption(i, j);
                    }

                }

            }
            return sum;
        }

        static void PrintTask() //метод для вывода процессов
        {

            Process[] procArray = Process.GetProcesses();
            foreach (Process proc in procArray)
            {
                Console.WriteLine($"{proc.Id}\t{proc.ProcessName}");
            }

        }
        static void KillTask(string id) //метод для завершения процесса по id
        {
            try
            {
                Process.GetProcessById(int.Parse(id)).Kill();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }

        }
        static void KillName(string name) //метод для завершения процесса по имени
        {
            try
            {

                Process[] procArray = Process.GetProcessesByName(name);
                foreach (Process proc in procArray)
                {
                    proc.Kill();
                }
                if (procArray.Length == 0)

                {
                    Console.WriteLine("Процесс с таким именем не найден");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }


        }

        private static bool Accept(string user) //метод для запуска команд
        {

            string[] data = user.Split(' ');

            if (data[0] == "byid")
            {
                KillTask(data[1]);
                return true;
            }
            else if (data[0] == "byname")
            {
                KillName(data[1]);
                return true;
            }
            else if (data[0] == "show")
            {
                PrintTask();
                return true;
            }
            else if (data[0] == "exit")
            {
                return false;
            }
            else
            {


                Console.WriteLine("Команда не опознана");
                return true;
            }

        }






    }
}
