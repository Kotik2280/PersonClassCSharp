using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Person : ID
    {
        static List<Person> persons = new List<Person>(); //Список созданных людей

        private string name;
        private int age;
        readonly public string ID;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string name = "Неизвестно", int age = 18)
        {
            ID = CreateID(); //Случайная генерация ID (ID не может повторяться)
            Name = name;
            Age = age;
            Console.WriteLine($"Человек {name} создан");

            persons.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}\nID: {ID}");
        }

        public static Person SearchByID(string id)
        {
            Console.WriteLine($"Поиск пользователя по ID {id}");
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].ID == id)
                {
                    Console.WriteLine("Результат найден!");
                    return persons[i];
                }
            }

            Console.WriteLine("Человека с таким ID не существует!");

            return null;
        }
    }
}
