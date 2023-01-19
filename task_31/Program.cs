int[] arr = new int[8]; 
int sumPositive = 0;
int sumNegative = 0; 

int[] FillArrWithRand(int[] array) {
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 10); 
    if(arr[i] > 0) {
        sumPositive += arr[i]; 
    } else {
        sumNegative += arr[i]; 
    }
}
return array; 
}

FillArrWithRand(arr); 
System.Console.WriteLine();
System.Console.WriteLine("Ваш массив: " + string.Join(", ", arr)); 
System.Console.WriteLine(sumPositive + " - сумма положительных");
System.Console.WriteLine(Math.Abs(sumNegative) + " - сумма отрицательных");