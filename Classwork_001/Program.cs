using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_001
{
    internal class Program
    {
        // Задание 5
        static List<Person> Ask_N_Times(int n)
        {
            var ans = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans.Add(CreatePerson());
            }
            return ans;
        }
        static Person CreatePerson()
        {
            string name;
            int age = 0;
            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();

            do
            {
                try
                {
                    Console.WriteLine("Введите возраст:");
                    age = int.Parse(Console.ReadLine());
                    if (age <= 0)
                    {
                        Console.WriteLine("Возраст не может быть 0 и ниже");
                    }
                    else if (age > 120)
                    {
                        Console.WriteLine("Слишком большой возраст");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Возраст введен некорректно");
                }
            } while (age <= 0 || age > 120);

            var person = new Person(name);
            person.Age = age;
            return person;
        }

        // Задание 6
        static public Tuple<int, int> GetTwoNumbers()
        {
            int firstNum = 10;
            int secondNum = 20;
         
            return Tuple.Create(firstNum, secondNum);
        }

        static void Main(string[] args)
        {
            // Задание 3
            Console.WriteLine("Задание 3.");
       
                if (args.Length > 0)
                {
                    int FarDG = int.Parse(args[0]);
                    float CelsDG = ((float)(FarDG - 32) / 9) * 5;
                    Console.WriteLine("Градусов по Фарингейту: " + FarDG + ", градусов по Цельсию: " + CelsDG);
                }
                else
                {
                    Console.WriteLine("Нет аргументов командной строки!");                    
                    Console.WriteLine("Введите число: ");
                    int FarDG = int.Parse(Console.ReadLine());
                    float CelsDG = ((float)(FarDG - 32) / 9) * 5;
                    Console.WriteLine("Градусов по Фарингейту: " + FarDG + ", градусов по Цельсию: " + CelsDG);
                }
                
            // Задание 4
            Console.WriteLine("\nЗадание 4.");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            // Задание 5
            int r;
            Console.WriteLine("\nЗадание 5.\nВведите количество людей: ");
            r = int.Parse(Console.ReadLine());
            var PersonList = Ask_N_Times(r);

            // с помощью оператора orderby
            var sortedPeople1 = from p in PersonList
                                orderby p.Name, p.Age descending  // сортировка по возрасту по убыванию
                                select p;
            //var sortedPeople = PersonList.OrderBy(p => p.Name).ThenByDescending(p => p.Age);

            foreach (Person person in sortedPeople1)
            {                          
                Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
            }

            // Задание 6
            Console.WriteLine("\nЗадание 6.");
            Tuple<int, int> result = GetTwoNumbers();
            Console.WriteLine(result.Item1); 
            Console.WriteLine(result.Item2);

            // Задание 7
            



        }
    }
}
