using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_001
{
    internal class Person
    {
        private string name;
        
        public string Name { /*set;*/ get { return name; } }

        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, возраст: {Age}");
            
        }

        public Person(string _name)
        {
            name = _name;
        }
    }
}
