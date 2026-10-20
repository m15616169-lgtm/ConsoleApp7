using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class
    {
        public Class[] Cla = new Class[5];
        public Student[] Stu = new Student[100];
        public Techer[] TU = new Techer[10];
        public string Name_Class;
        public string Number_Class;
        public static int Count = 0;
        public static int Count_Tu = 0;

        public void add(string  name , string number)
        {
            this.Name_Class = name;
            this.Number_Class = number;
        }
        public void Print()
        {
            
            Console.Write($"The Name class is : ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Name_Class}");
            Console.ResetColor();
            Console.Write(" / ");
            Console.Write($"The number class is : ");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"{Number_Class}");
            Console.ResetColor();
        }
        public void Print_All_Data()
        {
            
           
        }

    }
}
