// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

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