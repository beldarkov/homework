Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int n = 5;
int count = 0;

if (number.Length != n) { Console.WriteLine("Ошибка! Введено не пятизначное число"); }
else {
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] == number[number.Length - i - 1]) { count++; }
    }
    if (count == number.Length / 2) { Console.WriteLine($"{number} -> да"); }
    else { Console.WriteLine($"{number} -> нет"); }
}