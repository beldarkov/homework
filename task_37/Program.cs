// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива:"); 
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size]; 

int[] FillArrayFromKeyboard(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine($"Введите {i + 1}-ый элемент массива: "); 
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return arr; 
}
FillArrayFromKeyboard(array); 

int[] Method(int[] arr) {
    int newLength = arr.Length / 2 + arr.Length % 2; 
    int[] newArr = new int[newLength]; 
    for(int i = 0; i < arr.Length / 2; i++) {
        newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if(arr.Length % 2 > 0) {
        newArr[newArr.Length - 1] = arr[arr.Length / 2]; 
    } 
    return newArr; 
}
Console.WriteLine(string.Join(" ", Method(array))); 