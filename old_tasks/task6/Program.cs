// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число");
int number;
while (!Int32.TryParse(Console.ReadLine(), out number))
{   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
}

if (number % 2 == 0)
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число нечетное");
}