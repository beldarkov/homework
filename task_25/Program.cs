// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int B = Convert.ToInt32(Console.ReadLine());

int Pow(int x, int y) {
    int res = 1; 
    for(int i = 1; i <= y; i++) {
        res *= x; 
    }
    return res;
}

Console.WriteLine($"{A}, {B} -> {Pow(A, B)}"); 