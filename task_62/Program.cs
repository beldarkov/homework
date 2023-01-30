// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matr = new int[4,4]; 
int[,] FillMatr(int[,] matr) {
    int minRow = 0;
    int minColumn = 0; 
    int maxRow = 3;
    int maxColumn = 3;
    int result = 1; 
    while(result <= 16) {

        for(int i = minColumn; i <= maxColumn; i++) {
            matr[minRow, i] = result;
            result++;
        }
        for(int i = minRow + 1; i <= maxRow; i++) {
            matr[i, maxColumn] = result; 
            result++; 
        }
        for(int i = maxColumn - 1; i >= minColumn; i--) {
            matr[maxRow, i] = result;
            result++; 
        }
        for(int i = maxRow - 1; i >= minRow + 1; i--) {
            matr[i, maxColumn] = result;
            result++; 
        }
        minRow++;
        minColumn++;
        maxRow--;
        maxColumn--;
    }
    return matr;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillMatr(matr);
PrintArray(matr); 