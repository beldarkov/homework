Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0; 

if (a > b) {
    max = a; 
    Console.WriteLine("max = " + max);
} else if (a < b) {
    max = b; 
    Console.WriteLine("max = " + max);
} else {
    Console.WriteLine("Numbers are equal");
}