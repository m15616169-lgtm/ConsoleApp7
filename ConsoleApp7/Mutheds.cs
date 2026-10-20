using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Mutheds : Class
    {
        public void UI()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Show");

        }
        public void Add_New_Stu()
        {
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i] == null)
                {
                    Stu[i] = new Student();
                    Console.WriteLine("//// Student /////");
                    Console.Write("add name student : ");
                    string name = Console.ReadLine();
                    Console.Write("add age student : ");
                    string age = Console.ReadLine();
                    Student.Coun_Id = 310759 + i;
                    Stu[i].add(name, age);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        public void Add_New_Tech()
        {
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i] == null)
                {
                    TU[i] = new Techer();
                    Console.WriteLine("//// Techer /////");
                    Console.Write("add name Techer : ");
                    string name = Console.ReadLine();
                    Console.Write("add age Techer : ");
                    string age = Console.ReadLine();
                    Console.Write("add SY the techer : ");
                    string SY = Console.ReadLine();
                    Techer.Coun_TU = 101 + i;
                    TU[i].add(name, age, SY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        public void Add_New_Class()
        {
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] == null)
                {
                    Cla[i] = new Class();
                    Console.WriteLine("//// Class /////");
                    Console.Write("add name the class : ");
                    string name = Console.ReadLine();
                    Console.Write("add Number the class : ");
                    string number = Console.ReadLine();
                    Cla[i].add(name, number);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
        public void Delete_Stu()
        {
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i] != null)
                {
                    Stu[i].Print();
                }
            }
            Console.WriteLine("Add id student to delete : ");
            string id = Console.ReadLine();
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i].Id_St.ToString() == id)
                {
                    Stu[i] = null;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }

            }
        }
        public void Delete_Techer()
        {
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i] != null)
                {
                    TU[i].Print();
                }
            }
            Console.WriteLine("Add id Techer to delete : ");
            string id = Console.ReadLine();
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i].ID_TU.ToString() == id)
                {
                    TU[i] = null;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }

            }
        }
        public void Delete_Class()
        {
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] != null)
                {
                    Cla[i].Print();
                }
            }
            Console.WriteLine("Add number class to delete : ");
            string id = Console.ReadLine();
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i].Number_Class == id)
                {
                    Cla[i] = null;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }
            }
        }
        public void Edit_Techer()
        {
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i] != null)
                {

                    TU[i].Print();
                }

            }
            Console.WriteLine("Add number class to Edit : ");
            string id = Console.ReadLine();
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i].ID_TU.ToString() == id)
                {
                    TU[i] = null;
                    Add_New_Tech();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }
            }
        }
        public void Edit_Stu()
        {
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i] != null)
                {
                    Stu[i].Print();
                }
            }
            Console.WriteLine("Add number class to Edit : ");
            string id = Console.ReadLine();
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i].Id_St.ToString() == id)
                {
                    Stu[i] = null;
                    Add_New_Stu();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }
            }
        }
        public void Edit_Class()
        {
            for (int i = 0; i < Cla.Length; i++)
            {

                if (Cla[i] != null)
                {
                    Cla[i].Print();
                }
            }
            Console.WriteLine("Add number class to Edit : ");
            string id = Console.ReadLine();
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i].Number_Class == id)
                {
                    Cla[i] = null;
                    Add_New_Class();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("WELL DONE !!!!");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine("NOT FOUND TRY AGAIN PLASE !!!!!!!!");
                    break;
                }
            }
        }
        public void Show_Stu()
        {
            Console.WriteLine("///// Student //////");
            for (int i = 0; i < Stu.Length; i++)
            {
                if (Stu[i] != null)
                {
                    Stu[i].Print();
                }
            }
        }
        public void Show_Techer()
        {
            Console.WriteLine("///// Techer //////");
            for (int i = 0; i < TU.Length; i++)
            {
                if (TU[i] != null)
                {
                    TU[i].Print();
                }
            }
        }
        public void Show_Class()
        {
            Console.WriteLine("///// Class //////");
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] != null)
                {
                    Cla[i].Print();
                }
            }
        }
        public void Add_Stu_In_Class()
        {
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] != null)
                {
                    Cla[i].Print();
                }
            }
            Console.Write("Add number Class :");
            string num = Console.ReadLine();
            for (int i = 0; i < Cla.Length; i++)
            {
                bool loop = true;
                if (Cla[i] != null)
                {
                    if (Cla[i].Number_Class == num)
                    {
                        while (loop)
                        {
                            Show_Stu();
                            Console.WriteLine("Add ID student to add to class");
                            string num2 = Console.ReadLine();
                            for (int j = 0; j < Stu.Length; j++)
                            {
                                if (Stu[j] != null)
                                {
                                    if (Cla[i].Stu[j] == null)
                                    {
                                        if (Stu[j].Id_St.ToString() == num2)
                                        {
                                            Cla[i].Stu[Count] = Stu[j];
                                            Count++;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("WELL DONE !!!!");
                                            Console.ResetColor();
                                            Thread.Sleep(1000);
                                        }
                                    }
                                }


                            }
                            Console.WriteLine("Do you want add any new study in the class press y to cotunoe :");
                            if (Console.ReadLine() == "y")
                            {
                                loop = true;
                            }
                            else
                            {
                                loop = false;
                            }
                        }
                       

                    }
                }


            }
        }
        public void Add_Tucer_In_Class()
        {
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] != null)
                {
                    Cla[i].Print();
                }
            }
            Console.Write("Add number Class :");
            string num = Console.ReadLine();
            for (int i = 0; i < Cla.Length; i++)
            {
                bool loop = true;

                if (Cla[i] != null)
                {

                    if (Cla[i].Number_Class == num)
                    {
                        while (loop)
                        {
                            Show_Techer();
                            Console.WriteLine("Add ID student to add to class");
                            string num2 = Console.ReadLine();
                            for (int j = 0; j < TU.Length; j++)
                            {
                                if (TU[j] != null)
                                {
                                    if (Cla[i].TU[j] == null)
                                    {
                                        if (TU[j].ID_TU.ToString() == num2)
                                        {
                                            Cla[i].TU[Count_Tu] = TU[j];
                                            Count_Tu++;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("WELL DONE !!!!");
                                            Console.ResetColor();
                                            Thread.Sleep(1000);
                                        }
                                    }
                                }
                            }
                           
                            Console.WriteLine("Do you want add any new techer in the class press y to cotunoe :");
                            if (Console.ReadLine() == "y")
                            {
                                loop = true;
                            }
                            else
                            {
                                loop = false;
                            }
                        }
                       

                    }
                }


            }

        }
        public void Print_All_Data()
        {
            
            for (int i = 0; i < Cla.Length; i++)
            {
                if (Cla[i] != null)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("///// CLASS /////");
                    Console.ResetColor();
                    Cla[i].Print();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("///// TECHER /////");
                    Console.ResetColor();
                    for (int t = 0; t < TU.Length; t++)
                    {

                        if (Cla[i].TU[t] != null)
                        {
                            Cla[i].TU[t].Print();

                        }
                      
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("///// STUDEINT /////");
                    Console.ResetColor();
                    for (int j = 0; j < Stu.Length; j++)
                    {
                        if (Cla[i].Stu[j] != null)
                        {
                            Cla[i].Stu[j].Print();

                        }


                    }
                }
            }

        }
    }
}
