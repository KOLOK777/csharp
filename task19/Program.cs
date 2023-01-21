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

void Palindrom (int number){
    bool test = true;
    int beforeMidDigit = number / 10000;
    int afterMidDigit = number % 10;
    if (beforeMidDigit != afterMidDigit)
        test = false;
        return
    int beforeMidDigit = number / 1000;
    int beforeMidDigit = beforeMidDigit % 10;
    int afterMidDigit = number % 100;
    int afterMidDigit = afterMidDigit / 10;
    if (beforeMidDigit != afterMidDigit)
        test = false;
        return 
  
}

Palindrom (number);