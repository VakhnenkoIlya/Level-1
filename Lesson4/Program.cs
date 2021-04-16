using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для PullRequest");
            Console.WriteLine("Задание 1");

            Console.WriteLine(GetFullName("Ивонов", "Петр", "Сергеевич"));
            Console.WriteLine(GetFullName("Семенов", "Семен", "Семенович"));
            Console.WriteLine(GetFullName("Васильев", "Василий", "Васильевич"));

            Console.WriteLine("Задание 2");
            Console.WriteLine("введите цифры через пробел");

            Console.WriteLine(GetSum(Console.ReadLine()));


            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите номер месяца");
            bool seasonFlag;
            do
            {
                int monthNumber = int.Parse(Console.ReadLine());
                Seasons resultedSeason = GetSesons(monthNumber);
                Console.WriteLine(GetTranslator(resultedSeason));

                if (resultedSeason == Seasons.Eror)
                {
                    seasonFlag = true;
                }
                else
                {
                    seasonFlag = false;
                }
            } while (seasonFlag);

            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите номер элемента последовательности фиббоначи:");
            Console.WriteLine(GetFibbonaci(int.Parse(Console.ReadLine())));

            Console.WriteLine("Задание 5");
            string str1 = "Предложение один Теперь предложение два Предложение три";
            NormalizeString(str1);

        }


        static string GetFullName(string firstname, string lastname, string patronomyc) // метод к заданию 1
        {
            return ($"{firstname} {lastname} {patronomyc}");
        }
        static int GetSum(string inputString) // метод к заданию 2
        {
            string[] numbersArray = inputString.Split(' ');
            int result = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {

                result = result + int.Parse(numbersArray[i]);
            }
            return result;
        }
        static string GetTranslator(Seasons season) //метод к заднию 3
        {
            string result = "";
            if (season == Seasons.Winter)
                result = "Зима";
            if (season == Seasons.Spring)
                result = "Весна";
            if (season == Seasons.Summer)
                result = "Лето";
            if (season == Seasons.Autumn)
                result = "Осень";
            if (season == Seasons.Eror)
                result = "Ошибка: введите число от 1 до 12";
            return result;
        }

        static Seasons GetSesons(int numberMonth) // метод заданию 3
        {
            Seasons result;
            switch (numberMonth)
            {
                case 12:
                case 1:
                case 2:
                    result = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    result = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    result = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    result = Seasons.Autumn;
                    break;
                default:
                    result = Seasons.Eror;
                    break;

            }
            return result;

        }



        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter,
            Eror
        }
        static long GetFibbonaci(int count)
        {
            if (count == 1)
            {
                return 0;
            }
            else if (count == 2)
            {
                return 1;
            }
            else
            {
                return GetFibbonaci(count - 1) + GetFibbonaci(count - 2) + 1;
            }
        }

        static void NormalizeString(string badString)
        {

            string[] sentences = badString.Split(' ');
            string result = "";
            for (int i = 0; i < sentences.Length; i++)
            {

                result += sentences[i];

                if (i < sentences.Length - 2)
                {
                    if (sentences[i + 1].ToString().ToLower() != sentences[i + 1].ToString() && i != 0)
                    {
                        result += ".";
                    }
                }
                if (i != sentences.Length - 1)
                {
                    result += " ";
                }
                else
                {
                    result += ".";
                }

            }
            Console.WriteLine(result);
        }

    }

}
