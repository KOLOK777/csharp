// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine("Введите пятизначное число");
int number;
while (!Int32.TryParse(Console.ReadLine(), out number) || number > 99999 || number < -99999 || (number >= -9999 && number <= 9999))
    {
    Console.WriteLine("Ввdод неверный. Пожалуйста, введите корректное число");
    }





    Console.WriteLine("Это палиндром");
    Console.WriteLine("Это НЕ палиндром");