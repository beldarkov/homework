// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int A = Convert.ToInt32(Console.ReadLine());


int FindSumOfNumber(int num) {
    int res = 0;
    while (num > 0) {
        res += num % 10;
        num /= 10;
    }
    return res; 
}

void Print(int result) {
    Console.WriteLine(result); 
}

Print(FindSumOfNumber(A)); 

