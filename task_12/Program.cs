Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0)
{
    Console.WriteLine(num1 + ", " + num2 + "-> кратно");
}
else
{
    Console.WriteLine(num1 + ", " + num2 + "-> не кратно, остаток " + num1 % num2);
}