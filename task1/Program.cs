// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
int Prompt(string message){
System.Console.Write(message);
string readInput = System.Console.ReadLine();
int result = int.Parse(readInput);
return result;
}

int Stepen(int number1 , int number2){
    int stepen = 1;
    for (int i = 0; i<number2;i++){
        stepen = stepen *number1;
    }
    return stepen;
}
int number1 = Prompt("Введите первое число: ");
int number2 = Prompt("Введите второе число: ");
System.Console.WriteLine($"Число {number1} в степени {number2} = {Stepen(number1,number2)}");