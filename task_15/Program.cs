Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine($"{day} -> нет");
        break;
    case 2:
        Console.WriteLine($"{day} -> нет");
        break;
    case 3:
        Console.WriteLine($"{day} -> нет");
        break;
    case 4:
        Console.WriteLine($"{day} -> нет");
        break;
    case 5:
        Console.WriteLine($"{day} -> нет");
        break;
    case 6:
        Console.WriteLine($"{day} -> да");
        break;
    case 7:
        Console.WriteLine($"{day} -> да");
        break;
    default:
        Console.WriteLine("Такого дня нет!");
        break; 
}