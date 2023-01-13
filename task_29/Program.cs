// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[size]; 

int[] FillArrFromKeybord(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.WriteLine($"Введите {i + 1}-ый элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr; 
}

string result = string.Join(", ", FillArrFromKeybord(array)); 
Console.WriteLine($"{result} -> [{result}]");  