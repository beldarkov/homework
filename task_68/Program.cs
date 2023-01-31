int Akkerman(int a, int b) {
    if(a == 0) return b + 1;
    else if(a > 0 && b == 0) return Akkerman(a - 1, 1); 
    else return Akkerman(a - 1, Akkerman(a, b - 1)); 
    
}
System.Console.WriteLine(Akkerman(2, 3)); 