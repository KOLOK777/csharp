﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число"); 
int number;
while (!Int32.TryParse(Console.ReadLine(), out number))
    {   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    }

if (number >= 1000 || number <= -1000 || (number >= -99 && number <= 99))
{
  Console.WriteLine("Вы ввели не трехзначное число !");
}
else 
{
  int digit = number / 10;
  digit = digit % 10;
  Console.WriteLine("Вторая цифра: " + digit);
}