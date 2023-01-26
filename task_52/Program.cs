void FillArray(int[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            arr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void PrintArray(int[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] FindAverage(int[,] matr, int m, int n) {
    double[] avg = new double[m]; 
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < m; j++) {
            avg[i] += matr[j, i]; 
        }
        avg[i] /= m;
    }
    return avg;
}
Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] arr = new int[m, n]; 
FillArray(arr, m, n); 
PrintArray(arr, m, n);
System.Console.WriteLine();

double[] res = FindAverage(arr, m, n);
System.Console.WriteLine(string.Join(" ", res));