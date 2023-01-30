// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillRandom(int[,,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            for(int q = 0; q < matr.GetLength(2); q++) {
                matr[i, j, q] = new Random().Next(1, 10); 
            }
        }
    }
    return matr; 
}

int[,,] matrix = new int[2, 2, 2]; 
FillRandom(matrix); 

for(int i = 0; i < matrix.GetLength(0); i++) {
    for(int j = 0; j < matrix.GetLength(1); j++) {
        for(int q = 0; q < matrix.GetLength(2); q++) {
            System.Console.Write($"{matrix[j, q, i]}({j}, {q}, {i}) "); 
        }
        System.Console.WriteLine();
    }
}
