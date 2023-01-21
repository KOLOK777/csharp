// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

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
Console.WriteLine("Введите третье число");
int number3;
while (!Int32.TryParse(Console.ReadLine(), out number3))
{   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

int max = number1;

if (number2 >= max) 
{
    max = number2;   
}
if (number3 >= max) 
{
    max = number3;   
}

Console.WriteLine("Максимальное число получилось: " + max);