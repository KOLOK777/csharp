﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SUM (int[] array)
    {
    Console.WriteLine("Введите целое число");
    int number;
    while (!Int32.TryParse(Console.ReadLine(), out number))
        Console.WriteLine("Неверный ввод. Введите правильное целое число");
    int[] array = new int[1];
    int i = 0;
    array[0] = number % 10;
    int result = array[0];
    int number2 = number / 10;
        Console.Write($"Массив: [ {array[0]}");
    for (i = 1; number2 > 0; i++)
        {
        array = new int[array.Length + 1];
        array[i] = number2 % 10;
        number2 = number2 / 10;
        result = result + array[i];
        Console.Write($", {array[i]}");
        }
    Console.Write(" ]");
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр в вашем числе: {result}");
    return;    
    }

SUM (array);

