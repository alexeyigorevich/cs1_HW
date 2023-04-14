int a, b, c, result;


Console.WriteLine("Введите номер задачи: ");
switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Введите два числа");
        if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
        {
            if (a > b)
            {
                Console.Write("Большее из них: " + a);
            }
            else
            {
                Console.Write("Большее из них: " + b);
            }
        }
        else
        {
            Console.Write("Вы ввели неверные значения");
        }
        break;

}
fsdfsd