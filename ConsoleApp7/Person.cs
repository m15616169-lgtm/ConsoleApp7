using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Person
    {
        private string name;
        private string age;
        protected void add(string name , string age)
        {
            this.name = name;
            this.age = age;
        }
        protected void Print() 
        {
            Console.Write($"The name is : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{name}");
            Console.ResetColor();
            Console.Write(" / ");
            Console.Write($"The age is : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{age}");
            Console.ResetColor();
           
        }
    }
}
