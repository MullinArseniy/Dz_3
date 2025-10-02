using System;
using Dz_File_Week;

namespace DzFile
{
    class Program
    {
        static void Main()
        {
            //1
            Console.WriteLine("Задание 1");
            {

                double[] Digits = { 1, 2, 3, 4, 5, 8, 7, 8, 9, 10 };
                Console.WriteLine($"\nСтрока: {string.Join(", ", Digits)}");
                var k = 0;
                for (int i = 0; i < 10; i++)
                {
                    k = i;
                    if (Digits[i] > Digits[i + 1])
                    {
                        Console.WriteLine($"Номер числа нарушающего порядок: {k}");
                        break;
                    }
                }
            }

            //2
            Console.WriteLine("\nЗадание 2");
            {
                Console.Write("Введите номер карты (6-14): ");
                try
                {
                    var card = int.TryParse(Console.ReadLine(), out int cardnum);

                    string cardName;
                    switch (cardnum)
                    {
                        case 6: cardName = "Шестёрка"; break;
                        case 7: cardName = "Семёрка"; break;
                        case 8: cardName = "Восьмёрка"; break;
                        case 9: cardName = "Девятка"; break;
                        case 10: cardName = "Десятка"; break;
                        case 11: cardName = "Валет"; break;
                        case 12: cardName = "Дама"; break;
                        case 13: cardName = "Король"; break;
                        case 14: cardName = "Туз"; break;
                        default:
                            Console.WriteLine("Ошибка: введено неверное значение.");
                            return;
                            break;
                    }

                    Console.WriteLine("Достоинство карты: " + cardName);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Программа завершена.");
                }
            }



            //3
            Console.WriteLine("\nЗадание 3");
            {
                Console.Write("Введите строку: ");
                try
                {
                    var stroka = (Console.ReadLine()).ToLower();
                    switch (stroka)
                    {
                        case "jabroni": Console.WriteLine("Patron Tequila"); break;
                        case "school counselor": Console.WriteLine("Anything with Alcohol"); break;
                        case "programmer": Console.WriteLine("Hipster Craft Beer"); break;
                        case "bike gang member": Console.WriteLine("Moonshine"); break;
                        case "politician": Console.WriteLine("Your tax dollars"); break;
                        case "rapper": Console.WriteLine("Cristal"); break;
                        default:
                            Console.WriteLine("Beer");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }




            //4

            Console.WriteLine("\nЗадание 4");
            {
                Console.Write("Введите порядковый номер дня недели: ");
                var weekDay = int.TryParse(Console.ReadLine(), out int day);
                if (day <= 0 || day > 7)
                {
                    Console.WriteLine("Некорректный ввод данных");
                }
                else
                {
                    Console.WriteLine((Week)(day - 1));
                }
            }


            //5
            Console.WriteLine("\nЗадание 5");
            {
                var toysInBag = 0;
                string[] Bag = { "Teddy Bear", "Buzz Lighter", "Woody", "Hello Kitty", "Jessie", "Barbie doll" };
                foreach (string doll in Bag)
                {
                    if (doll == "Hello Kitty" || doll == "Barbie doll")
                    {
                        toysInBag++;
                    }
                }
                Console.WriteLine(string.Join(", ", Bag));
                Console.WriteLine($"Количество кукол в сумке: {toysInBag}");
            }
        }
    }
}

           