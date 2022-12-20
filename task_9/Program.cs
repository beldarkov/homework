int num = new Random().Next(10, 100);
Console.WriteLine(num); 
int digit1 = num / 10; 
int digit2 = num % 10; 
if(digit1 > digit2) {
    Console.WriteLine("Первая цифра больше второй");
} else {
    Console.WriteLine("Вторая больше первой");
}