﻿Console.WriteLine("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите координату у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());   

Console.WriteLine("Введите координату х2: ");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());  
  
double res = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2);
 
Console.WriteLine(res); 