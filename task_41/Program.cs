
int[] FillArrayFromKeyboard(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        System.Console.Write($"Введите {i + 1}-ый элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return arr; 
}
int CountNegative(int[] arr) {
    int count = 0; 
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] < 0) {
            count++;
        }
    }
    return count; 
}
System.Console.Write("Введите размер массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M]; 
FillArrayFromKeyboard(array);
System.Console.WriteLine((string.Join(", ", array)) + " -> " + CountNegative(array));