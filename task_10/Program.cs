Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("Введено не трёхзначное число!");
        Console.WriteLine("Введите трёхзначное число: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        break;
    }
}
int res = (num / 10) % 10;
Console.WriteLine($"{num} -> {res}");
