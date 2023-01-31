void PrintNumb(int a) {
    if(a == 0) return; 
    System.Console.Write(a + " ");
    PrintNumb(a - 1);
}

System.Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine()); 
PrintNumb(N); 