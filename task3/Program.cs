// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Clear();
int Prompt(string message){
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
return result;}
int[] array = MyArray(8);
int[] MyArray(int size){
int[] masiv = new int[size];
for(int i = 0 ; i< size ; i++){
    masiv[i] = new Random().Next(0,100);
}
return masiv;
}
Console.WriteLine($"[{String.Join(" , ", array)}]");
// чтобы вывести их сумму 
//int GetSum(int[]masiv){
//int sum = 0
//for(int i = 0 ; i< size ; i++)
//sum = sum + result[i]
//return sum
//Console.WriteLine($"Sum is {GetSum(array)}")