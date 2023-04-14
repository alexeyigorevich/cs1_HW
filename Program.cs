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

    case "2":
        Console.WriteLine("Введите три числа:");
        if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
        {
            result = a;
            if (b > result)
            {
                result = b;
            }
            if (c > result)
            {
                result = c;
            }
            Console.Write("Большее из них: " + result);
        }
        else
        {
            Console.Write("Вы ввели неверные значения");
        }
        break;

    case "3":
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out a))
        {
            if (a % 2 == 0)
            {
                Console.Write("Число " + a + " является четным.");
            }
            else
            {
                Console.Write("Число " + a + " является нечетным.");
            }
        }
        break;

}
