Console.WriteLine("Введите х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите у: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x != 0 && y != 0)
{
    if (x > 0 && y > 0) { Console.WriteLine("1"); }
    if (x < 0 && y > 0) { Console.WriteLine("2"); }
    if (x < 0 && y < 0) { Console.WriteLine("3"); }
    if (x > 0 && y < 0) { Console.WriteLine("4"); }
}
else {
    Console.WriteLine("х или у не может равняться 0");
}