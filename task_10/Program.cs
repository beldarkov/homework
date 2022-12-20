Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool flag = false;
if (num < 100 || num >= 1000)
{
    Console.WriteLine("Введено не трёхзначное число!");
    flag = true;
}
if (flag == false)
{
    int res = (num / 10) % 10;
    Console.WriteLine($"{num} -> {res}");
}

