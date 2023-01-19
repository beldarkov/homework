// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = {-4, -8, 8, 2}; 

int[] ChangeNum(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] < 0) {
            arr[i] = Math.Abs(arr[i]); 
        } else {
            arr[i] = -arr[i];
        }
    }
    return arr; 
}
System.Console.WriteLine(string.Join(" ", ChangeNum(array)));
