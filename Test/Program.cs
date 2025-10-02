//4

Console.WriteLine("\nЗадание 4");
{
    Console.Write("Введите порядковый номер дня недели: ");
    try
    {
        var weekDay = int.TryParse(Console.ReadLine(), out int day);

        if (day < 0 || day > 7)
        {
            Console.WriteLine("В неделе всего семь дней, тупень");
        }
        else
        {
            Console.WriteLine((Week)(day - 1));
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: введено не число.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Произошла ошибка: " + ex.Message);
    }

}
