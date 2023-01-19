// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] arr = {3, 7, 19, 345, 3}; 
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool flag = false; 
int[] CheckNum(int[] array) {
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == n) {
            flag = true; 
            break; 
        }
    }
    return array; 
}
CheckNum(arr); 
string result = string.Join(", ", arr);
System.Console.WriteLine("[" + result + "]" + " -> " + (flag ? "да" : "нет"));