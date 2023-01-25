void FillArray(int[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            arr[i, j] = new Random().Next(1, 100); 
        }
    }
}

void PrintArray(int[,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for(int j = 0; j < n; j++) {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Console.Write("Введите i индекс: ");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите j индекс: ");
int b = Convert.ToInt32(Console.ReadLine());

int m = 3; 
int n = 4;

int[,] matrix = new int[m, n]; 
FillArray(matrix, m, n);
PrintArray(matrix, m, n);
int result = 0; 
bool flag = false;
for(int i = 0; i < m; i++) {
    for(int j = 0; j < n; j++) {
        if(i == a && j == b) {
            result = matrix[i, j]; 
            flag = true; 
        }
    }
}
System.Console.WriteLine(flag ? "Ваше число: " + result : "Такого числа в массиве нет");