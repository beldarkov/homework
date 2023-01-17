// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayRandom(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}
int SumOfOddIndex(int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (i % 2 != 0) {
            sum += arr[i];
        }
    }
    return sum; 
}

int size = 4;
int[] array = new int[size];
FillArrayRandom(array);
int sum = SumOfOddIndex(array); 
System.Console.WriteLine(string.Join(", ", array) + " -> " + sum);
