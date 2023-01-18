// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number;
while (!Int32.TryParse(Console.ReadLine(), out number))
    {   
    Console.WriteLine("Ввdод неверный. Пожалуйста, введите корректное число");
    }

if (number > 7 || number < 1)
    Console.WriteLine("Вы ввели неверный номер");
else if (number == 6 || number == 7)
        Console.WriteLine("Это выходной день !");
    else
        Console.WriteLine("Это рабочий день !");