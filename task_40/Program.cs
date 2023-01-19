// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

string IsExist(int A, int B, int C) {
    string result = String.Empty; 
    if(A + B > C && A + C > B && B + C > A) {
        result = "Существует";
    } else {
        result = "Не существует"; 
    }
    return result; 
}
System.Console.WriteLine("Введите 1 сторону: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2 сторону: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 3 сторону: ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(IsExist(a, b, c));