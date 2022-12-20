Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{

    string third = Convert.ToString(num);
    char ch = third[2];
    Console.WriteLine($"{num} -> {ch}");
}