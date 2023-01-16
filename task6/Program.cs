// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

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
