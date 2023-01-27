// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[] Sort(int[] array) {
    for(int i = 1; i < array.Length; i++) {
        for(int j = 0; j < array.Length - i; j++) {
        int temp = 0;
            if(array[j] < array[j + 1]) {
            temp = array[j]; 
            array[j] = array[j + 1];
            array[j + 1] = temp; 
            }
        }
    }
    return array; 
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] arr = new int[matrix.GetLength(1)]; 

System.Console.WriteLine();
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix); 

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        arr[j] = matrix[i, j];
        Sort(arr);
    }
    System.Console.WriteLine(string.Join("\t", arr));
    arr = new int[matrix.GetLength(1)];
}

