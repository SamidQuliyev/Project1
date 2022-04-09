using System;

namespace Classes
{
        class Person
    {

        public string Name;
        public string Surname;
        public int Age;
        public Person()
        {
            Console.WriteLine("Bir person yarandi");
        }

        public Person(string name, string surname):this()
        {
            Name = name;
            Surname = surname;
        }
        public Person(string name, string surname, int age) : this(name, surname)
        {
           
            Age = age;

        }
    }
}


















