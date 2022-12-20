Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if((Math.Pow(num1, 2) == num2) || (Math.Pow(num2, 2) == num1)) {
    Console.WriteLine(num1 + ", " + num2 + " -> да");
} 
else {
    Console.WriteLine(num1 + ", " + num2 + " -> нет");
}