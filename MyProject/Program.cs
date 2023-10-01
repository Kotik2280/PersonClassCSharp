using ConsoleApp19;
using System;

namespace Test
{
    class Lesson
    {
        static void Main()
        {
            Person person1 = new Person("Николай", 19);
            Person person2 = new Person("Андрей", 25);
            Person person3 = new Person("Сергей", 23);

            Console.WriteLine("------------------------------");
            person1.PrintInfo();
            Console.WriteLine("------------------------------");
            person2.PrintInfo();
            Console.WriteLine("------------------------------");
            person3.PrintInfo();
            Console.WriteLine("------------------------------");

            //Поиск по известному ID и вывод информации
            Person.SearchByID(person2.ID).PrintInfo();

            Console.WriteLine("------------------------------");

            //Поиск по случайному ID (Несуществующему)
            Person.SearchByID("25462");
        }
    }
}