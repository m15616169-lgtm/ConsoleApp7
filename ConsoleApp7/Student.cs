using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Student : Person
    {
        public int Id_St { get; set; }
        public static int Coun_Id = 310759;
        public void add(string name , string age)
        {
            Id_St = Coun_Id;
            base.add(name, age);
            
        }
        public void Print()
        {
            Console.Write($"The ID in Unverctity is : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{Id_St}");
            Console.ResetColor();
            Console.Write(" / ");
            base.Print();

        }
    }
}
