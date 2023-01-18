//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
         
Console.WriteLine("Введите первое число");
int number1;
while (!Int32.TryParse(Console.ReadLine(), out number1))
{   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}
Console.WriteLine("Введите второе число");
int number2;
while (!Int32.TryParse(Console.ReadLine(), out number2))
{   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

if (number1 == number2)
{
Console.WriteLine("числа одинаковые !");
}
 else
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
