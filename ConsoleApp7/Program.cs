using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Mutheds x = new Mutheds();
            while (true) 
            {
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Techer");
                Console.WriteLine("3. Class");
                switch (Console.ReadLine()) 
                {
                    case "1":
                        x.UI();
                        switch(Console.ReadLine())
                        {
                            case "1":
                                x.Add_New_Stu();
                                Console.Clear();
                                break;
                            case "2":
                                x.Edit_Stu();
                                Console.Clear();
                                break;
                            case "3":
                                x.Delete_Stu();
                                Console.Clear();
                                break;
                            case "4":
                                x.Show_Stu();
                                Console.ReadKey();
                                Console.Clear();
                                break;

                        }
                    break;
                    case "2":
                      x.UI();
                       switch (Console.ReadLine())
                       {
                            case "1":
                                x.Add_New_Tech();
                                Console.Clear();
                                break;
                            case "2":
                                x.Edit_Techer();
                                Console.Clear();
                                break;
                            case "3":
                                x.Delete_Techer();
                                Console.Clear();
                                break;
                            case "4":
                                x.Show_Techer();
                                Console.ReadKey();
                                Console.Clear();
                                break;

                       }
                    break;
                    case "3":
                      x.UI();
                        Console.WriteLine("5. Add Student in calss");
                        Console.WriteLine("6. Add Techer in calss");
                        Console.WriteLine("7. Print all data");
                       switch (Console.ReadLine())
                       {
                            case "1":
                                x.Add_New_Class();
                                Console.Clear();
                                break;
                            case "2":
                                x.Edit_Class();
                                Console.Clear();
                                break;
                            case "3":
                                x.Delete_Class();
                                Console.Clear();
                                break;
                            case "4":
                                x.Show_Class();
                                Console.Clear();
                                break;
                            case "5":
                                x.Add_Stu_In_Class();
                                Console.Clear();
                                break;
                                case "6":
                                x.Add_Tucer_In_Class();
                                Console.Clear();
                                break;
                            case "7":
                                x.Print_All_Data();
                                Console.ReadKey();
                                Console.Clear();
                                break;


                       }
                    break;

                }
            
            }
           
        }
    }
}
