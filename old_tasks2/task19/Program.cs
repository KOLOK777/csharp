//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
//(НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. 
//Используем операторы % и /).
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number;
while(!Int32.TryParse(Console.ReadLine(), out number) || (number < 10000 && number > -10000) || number >= 100000 || number <= -100000 )
    Console.WriteLine("Введено неверно. Введите пятизначное число: ");

void Palindrom (int number)
    {
    bool testTrue;
    if ((number / 10000 == number % 10) && (number / 1000 % 10 == number / 10 % 10))
        testTrue = true;
    else
        testTrue = false;
    if (testTrue == true)
        Console.WriteLine($"Веведено пятизначное число: {number}, это палиндром - 'да'");
    else
        Console.WriteLine($"Веведено пятизначное число: {number}, это НЕ палиндром - 'нет'");
    return;    
    }
    
Palindrom (number);