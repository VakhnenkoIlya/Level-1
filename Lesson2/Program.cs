using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите минимальную температуру воздуха за сутки");
            Double tmin = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру воздуха за сутки");
            Double tmax = double.Parse(Console.ReadLine());
            Double tmid = (tmin + tmax) / 2;
            Console.WriteLine($"Среднесуточная температура {tmid}");

            Console.WriteLine("Задание 2");
            Console.WriteLine("введите номер текущего месяца");
            int monthofyear = int.Parse(Console.ReadLine());

            string monttitle = "";
            switch (monthofyear)
            {
                case 1:
                    monttitle = "январь";
                    break;
                case 2:
                    monttitle = "февраль";
                    break;
                case 3:
                    monttitle = "март";
                    break;
                case 4:
                    monttitle = "апрель";
                    break;
                case 5:
                    monttitle = "май";
                    break;
                case 6:
                    monttitle = "июнь";
                    break;
                case 7:
                    monttitle = "июль";
                    break;
                case 8:
                    monttitle = "август";
                    break;
                case 9:
                    monttitle = "сентябрь";
                    break;
                case 10:
                    monttitle = "октябрь";
                    break;
                case 11:
                    monttitle = "ноябрь";
                    break;
                case 12:
                    monttitle = "декабрь";
                    break;

                default:
                    monttitle = "ошибка";
                    break;
            }
            Console.WriteLine(monttitle);

            Console.WriteLine("Задание 3");
            Console.WriteLine("Ввведите любое целое число");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)

                Console.WriteLine("Четное");

            else

                Console.WriteLine("Нечетное");

            Console.WriteLine("Задание 4");
            string receiptName = "Кассовый ЧЕК";

            int refuelingNumber = 209;
            int cashboxNumber = 1;
            string worker = "Иванова И.И.";
            long ITN = 390000_0000; //ИНН
            int xNumber1 = 2;
            double priceInRub = 50.95;
            double litres = 45;
            double totalCost = priceInRub * litres;
            double customerCash = 5000;
            double oddMoney = customerCash - totalCost;
            long EKLZ = 3297258661;
            int receiptNumber = 924;
            DateTime purchaseDate = new DateTime(2021, 3, 31, 11, 32, 00);
            int xNumber3 = 54668236;
            string hrline = "____________________________";

            Console.WriteLine($"       {receiptName} \n");
            Console.WriteLine($"АЗС Лукойл {refuelingNumber}       КАССА {cashboxNumber}");
            Console.WriteLine($"Оператор        {worker}");
            Console.WriteLine($"ИНН               {ITN}");
            Console.WriteLine($"ТРК№{xNumber1}     АИ-95         {litres} л");
            Console.WriteLine($"ЦЕНА              {priceInRub} X {litres}");
            Console.WriteLine($"{hrline}\n");
            Console.WriteLine($"Итого                {totalCost}");
            Console.WriteLine($"{hrline}");
            Console.WriteLine($"Рубли                {totalCost}");
            Console.WriteLine($"Наличными           {customerCash.ToString("N2")}");
            Console.WriteLine($"Сдача                {oddMoney}");
            Console.WriteLine($"ЭКЛЗ {EKLZ}");
            Console.WriteLine("     СПАСИБО ЗА ПОКУПКУ! \n    Приезжайте к нам еще!");
            Console.WriteLine($"ЧЕК {receiptNumber:0000} {purchaseDate} ");
            Console.WriteLine($"ФИСКАЛЬНЫЙ РЕЖИМ    {xNumber3}");

            Console.WriteLine("Задание 5");
            Console.WriteLine("Нажмите enter");
            Console.ReadLine();
            if (tmid > 0 && (monthofyear == 1 || monthofyear == 2 || monthofyear == 1))
                Console.WriteLine("Дождливая зима");
            else
                Console.WriteLine("Переходим к следующему заданию");


            WorkDays workOfice1 = (WorkDays)0b_1111100;
            WorkDays workOfice2 = (WorkDays)0b_1111111;

            WorkDays mondayToFriday = WorkDays.Monday | WorkDays.Thursday | WorkDays.Wednesday | WorkDays.Thursday | WorkDays.Friday;
            WorkDays modayToSunday = WorkDays.Monday | WorkDays.Thursday | WorkDays.Wednesday | WorkDays.Thursday | WorkDays.Friday | WorkDays.Saturday | WorkDays.Sunday;

            Console.WriteLine("Нажмите enter для того что бы узнать как работают офисы");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine($"Режим работы офиса 1 {workOfice1}");
            Console.WriteLine($"Режим работы офиса 1 {workOfice2}");

            if (workOfice1 == mondayToFriday && workOfice2 == modayToSunday) ;
            {
                Console.WriteLine("Режимы работы соответствуют битовым маскам");
            }









        }
        [Flags]
        enum WorkDays
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000

        }
    }

}
