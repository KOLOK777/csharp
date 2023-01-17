// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число"); 
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1000 || number <= -1000 || (number >= -99 && number <= 99))
    {
    Console.WriteLine("Вы ввели неправильное число. Введите трехзначное число");
    }
int digit = number / 10;
int digit = digit % 10;

Console.WriteLine(digit);


