Console.Write("Введите четверть (число от 1 до 4 включительно): ");
int chap = Convert.ToInt32(Console.ReadLine());
if (chap >= 1 || chap <= 4) { Console.WriteLine("Такой четверти нет"); }
if (chap == 1) { Console.WriteLine("x > 0 && y > 0"); }
if (chap == 2) { Console.WriteLine("x < 0 && y > 0"); }
if (chap == 3) { Console.WriteLine("x < 0 && y < 0"); }
if (chap == 4) { Console.WriteLine("x > 0 && y < 0"); }
