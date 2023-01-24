// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int number;
int power;
Console.WriteLine("Введите целое число, которое будем возводить в степень");
while (!Int32.TryParse(Console.ReadLine(number), out number))
    Console.WriteLine("Неверный ввод. Введите правильное целое число");
Console.WriteLine($"Введите степень, в которую будем возводить число {number}");
while (!Int32.TryParse(Console.ReadLine(), out power))
    Console.WriteLine("Неверный ввод. Введите правильное целое число");

double raisedPower()
    {
    double result = Math.Pow(number, power);
    Console.WriteLine($"Результат возвдения числа {number} в степень {power} : {result}");
    return result;
    }

raisedPower ();