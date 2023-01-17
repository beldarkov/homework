// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayRandom(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(100, 1000); 
    }
    return arr; 
}
int CheckEven(int[] arr) {
    int count = 0; 
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] % 2 == 0) {
            count++; 
        }
    }
    return count; 
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] mass = new int[size];
FillArrayRandom(mass); 
int result = CheckEven(mass); 
System.Console.WriteLine((string.Join(" | ", mass)) + " -> " + result);

