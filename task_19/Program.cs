Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int n = number.Length;
int count = 0;

if (n != 5) { Console.WriteLine("Ошибка! Введено не пятизначное число"); }
else {
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] == number[n - i - 1]) { count++; }
    }
    if (count == n / 2) { Console.WriteLine($"{number} -> да"); }
    else { Console.WriteLine($"{number} -> нет"); }
}