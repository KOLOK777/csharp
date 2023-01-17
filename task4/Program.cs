// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());
int max = number1;

if (number1 == number2)
{
Console.WriteLine("числа одинаковые !");
}
    if (number1 > number2) 
{
        Console.WriteLine("бОльшее число: " + number1);
        Console.WriteLine("мЕньшее число: " + number2);
}
    else 
{
        Console.WriteLine("бОльшее число: " + number2);
        Console.WriteLine("мЕньшее число: " + number1);
}