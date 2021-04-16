using System;

namespace Lesson5
{
    class Person
    {
        public string Name { get; }

        public string Position { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Salary { get; set; }

        public int Age { get; set; }

        public void GetWrite()
        {
            Console.WriteLine(Name, Position, Email, Phone, Salary, Age);
        }
        public Person(string name, string position, string email, string phone, int salary, int age)
        {
            Name = name;
            Position = position;
            Email = email;
            Phone = phone;
            Salary = salary;
            Age = age;



        }





    }
}
