Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine(num + " -> да");
}
else
{
    Console.WriteLine(num + " -> нет");
}