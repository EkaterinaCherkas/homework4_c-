// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12+
Console.Clear();
int Prompt(string message){
    System.Console.Write(message);//Выводим предложение ко входу
    string readInput=System.Console.ReadLine();
    int result = int.Parse(readInput);//Приводим к числу
    return result;//возвращаем результат
}
int Summa(int number){
    int result = 0;
    if (number < 0 ){
        number = number*(-1);
        result = result + number%10;  // 9012 %10 =2 %100=12 /10= 901
        number = number/10;

    }
    while (number > 0){
        result = result + number%10;  // 9012 %10 =2 %100=12 /10= 901
        number = number/10;

    }
    return result;
}
int number = Prompt("Введите число: ");
Console.WriteLine($"{number} = {Summa(number)}");