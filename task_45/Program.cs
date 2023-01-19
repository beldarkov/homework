int[] arr1 = new int[5]; 
for(int i = 0 ; i < arr1.Length; i++) {
    arr1[i] = new Random().Next(0, 100); 
}
int[] arr2 = new int[arr1.Length]; 
for(int i = 0 ; i < arr2.Length; i++) {
    arr2[i] = arr1[i]; 
}
System.Console.WriteLine(string.Join(", ", arr1));
System.Console.WriteLine(string.Join(", ", arr2));