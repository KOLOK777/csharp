// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N (больше 1): ");
int N = int.Parse(Console.ReadLine());
int count = 4;

Console.WriteLine("ИТОГ:");

if (N <= 1)
{
Console.WriteLine("в промежутке нет четных чисел !");    
}
else
    Console.Write(count-2);
    while (count <= N)
    {
        Console.Write(", " + count);
        count = count + 2;
    }