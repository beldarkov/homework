int sum = 0;
int Sum(int a, int b) {
    if(a > b) return 1;
    sum += b;
    Sum(a, b - 1); 
    return sum; 
}
int n = 5; 
int m = 10; 
System.Console.WriteLine("Сумма - " + Sum(n, m));