
void Fibonacci(int a) {
int[] arr = new int[a]; 
arr[0] = 0;
arr[1] = 1;
for(int i = 2; i < a; i++) {
    arr[i] = arr[i - 2] + arr[i - 1]; 
}
System.Console.WriteLine(string.Join(" ", arr));
}

System.Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine()); 
Fibonacci(N); 