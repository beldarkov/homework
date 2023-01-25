void FillArray(double[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            arr[i, j] = new Random().Next(-10, 10) + new Random().NextDouble(); 
            arr[i, j] = Math.Round(arr[i, j], 1); 
        }
    }
}

void PrintArray(double[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
double[,] arr = new double[m, n]; 
FillArray(arr, m, n); 
PrintArray(arr, m, n);