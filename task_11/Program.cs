int num = new Random().Next(100, 1000);
int digit1 = num / 100;
int digit3 = num % 10;
Console.WriteLine("Случайное - " + num);

int res = digit1 * 10 + digit3;
Console.WriteLine(res);