void FillArray(int[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            arr[i, j] = new Random().Next(1, 4); 
            if(i % 2 == 0 && j % 2 == 0) {
                arr[i, j] = arr[i, j] * arr[i, j]; 
            }
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

Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] arr = new int[m, n]; 
FillArray(arr, m, n); 
PrintArray(arr, m, n); 