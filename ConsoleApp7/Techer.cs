using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Techer : Person
    {
        public string SY_Techer { get; set; }
        public int ID_TU;
       public static int Coun_TU = 101;
        public void add(string name, string age , string SY)
        {
            ID_TU = Coun_TU;
            base.add(name, age);
            SY_Techer = SY;
           
        }
        public void Print()
        {
           
            Console.Write($"The ID techer in Unvercity is : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{ID_TU}");
            Console.ResetColor();
            Console.Write(" / ");
            Console.Write($"The SY_Techer is : ");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write($"{SY_Techer}");
            Console.ResetColor();
            Console.Write(" / ");
            base.Print();

        }
    }
}
