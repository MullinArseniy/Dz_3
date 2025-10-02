using Microsoft.VisualBasic;
using System;
using Dz_Tumakov_Enums;

namespace DzTumakov
{
    class Program
    {
        static void Main()
        {
            //1
            Console.WriteLine("Задание 1");
            Console.Write("\nВведите год: ");
            var year = int.TryParse(Console.ReadLine(), out int yearnum);
            if ((yearnum % 400 == 0) || (yearnum % 100 != 0 & yearnum % 4 == 0))
            {
                Console.Write("\nВведите количетсво дней: ");
                var day = double.TryParse(Console.ReadLine(), out double days);
                if (days > 0 & days < 367)
                {
                    int[] DaysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    var k = 0;
                    var DayOfMonth = days;
                    foreach(int n in DaysInMonth)
                    {
                        if (DayOfMonth - n  <= 0)
                        {
                            break;
                        }
                        else
                        {
                            DayOfMonth -= n;
                            k += 1;
                        }
                    }
                    Console.WriteLine($"\nМесяц:{(Months)k}\tДень:{DayOfMonth}");


                }
                else
                {
                    Console.WriteLine("\nНеверное количество дней");
                }
            }
            else
            {
                Console.Write("\nВведите количетсво дней: ");
                var day = int.TryParse(Console.ReadLine(), out int days);
                if (days > 0 & days < 366)
                {
                    int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    var k = 0;
                    var DayOfMonth = days;
                    foreach (int n in DaysInMonth)
                    {
                        if (DayOfMonth - n <= 0)
                        {
                            break;
                        }
                        else
                        {
                            DayOfMonth -= n;
                            k += 1;
                        }
                    }
                    Console.WriteLine($"\nМесяц:{(Months)k}\tДень:{DayOfMonth}");
                }
                else
                {
                    Console.WriteLine("\nНеверное количество дней");
                }
            }   
        }
    }
}

