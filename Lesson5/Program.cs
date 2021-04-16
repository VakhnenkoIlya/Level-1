using System;

using System.IO;
namespace Lesson5
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            string filename = "startup.txt";
            File.WriteAllText(filename, "Этот файл введен с клавиатуры \n");

            Console.WriteLine("Задание 2");

            File.AppendAllText(filename, DateTime.Now.ToString());

            Console.WriteLine("Задание 3");

            byte[] aray = { 1, 3, 4, 9 };
            File.WriteAllBytes("bytes.bin", aray);


            Console.WriteLine("Задание 4");

            Person[] persArray = new Person[5];
            persArray[0] = new Person("Sidorov Ivan", "manager", "si@mail.ru", "+79001111111", 25000, 25);
            persArray[1] = new Person("Petrov Petr", "engineer", "PP@mail.ru", "+79002222222", 30000, 30);
            persArray[2] = new Person("Ivanov Ivan", "operator", "ii@mail.ru", "+79003333333", 20000, 45);
            persArray[3] = new Person("Fedorov Fedor", "operator", "ff@mail.ru", "+79004444444", 20000, 35);
            persArray[4] = new Person("Egorov Egor", "director", "ee@mail.ru", "+79005555555", 50000, 50);

            foreach (Person pers in persArray)
            {
                if (pers.Age > 40)
                {
                    pers.GetWrite();
                }
            
            }






        }
    }
}