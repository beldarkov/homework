// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayRandom(double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().NextDouble() * 100;
        arr[i] = Math.Round(arr[i], 1); 
    }
    return arr;
}
double DiffBetweenMaxAndMin(double[] arr) {
    double min = arr[0];
    double max = arr[0]; 
    for(int i = 1; i < arr.Length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
        if(arr[i] < min) {
            min = arr[i]; 
        }
    }
     double diff = max - min;
     return Math.Round(diff, 1); 
}

double[] array = new double[5]; 
System.Console.WriteLine((string.Join("   ", FillArrayRandom(array))) + " -> " + DiffBetweenMaxAndMin(array));
