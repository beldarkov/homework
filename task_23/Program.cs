Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[N + 1];
for (int i = 1; i < arr.Length; i++)
{
    arr[i] = Math.Pow(i, 3);
}
Console.Write($"{N} -> ");
for (int i = 1; i < arr.Length; i++)
{
    if (i == N)
    {
        Console.Write(arr[i]);
    }
    else
    {
        Console.Write(arr[i] + ", ");
    }
}