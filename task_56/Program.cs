﻿// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinRow(int[] arr) {
    int min = arr[0]; 
    int row = 1; 
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] < min) {
        min = arr[i]; 
        row = i + 1;
        }
    } 
    return row;
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] sum = new int[matrix.GetLength(0)]; 
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);

// Заполнение одномерного массива суммами
for (int i = 0; i < matrix.GetLength(0); i++) {
    int res = 0; 
    for (int j = 0; j < matrix.GetLength(1); j++) { 
        res += matrix[i, j]; 
    }
    sum[i] = res; 
}
System.Console.WriteLine(string.Join(" ", sum)); // Вывод массива сумм для удобства проверки
System.Console.WriteLine($"Минимальная сумма находится в {FindMinRow(sum)} строке");