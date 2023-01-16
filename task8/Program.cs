// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Writeline("Введите первое число")
int number1 = convert.ToInt(Console.ReadLine())
Console.Writeline("Введите второе число")
int number2 = convert.ToInt(Console.ReadLine())

if (number1 == number2)
{
Console.Writeline("числа одинаковые !")
}
    if (number1 > number2) 
{
        Console.Writeline("бОльшее число: " + number1)
        Console.Writeline("мЕньшее число: " + number2)
}
    else 
{
        Console.Writeline("бОльшее число: " + number2)
        Console.Writeline("мЕньшее число: " + number1)
}
