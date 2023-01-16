// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Writeline("Введите число N ")
int N = convert.ToInt32(Console.ReadLine())
count = 4

if (N=1)
{
Console.Writeline("В промежутке нет четных чисел !")    
}
else
    Console.Writeline(count-2)
    while (count <= N)
    {
        Console.Writeline(", " count)
    }
    count = count + 2