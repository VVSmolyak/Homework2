// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1

//1.принимает на вход трёхзначное число

Console.WriteLine ("Введите трёхзначное число: ");
int number = EnterThreeDigitNumber ();

int digit2 = ShowSecondDigit (number);

Console.WriteLine ("Вторая цифра трехзначного числа: " + digit2);

int EnterThreeDigitNumber () {
    int number = int.Parse (Console.ReadLine ()!);
    return number;
}
int ShowSecondDigit (int number){
    int digit2 = (number % 100) / 10;
    return digit2;
}


