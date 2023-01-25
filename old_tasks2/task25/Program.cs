// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int number;
int power;
Console.WriteLine("Введите целое число, которое будем возводить в степень :");
while (!Int32.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Неверный ввод. Введите правильное целое число");
Console.WriteLine($"Введите степень, в которую будем возводить число '{number}' (натуральное - целое неотрицательное число) :");
while (!Int32.TryParse(Console.ReadLine(), out power) || power < 0)
    Console.WriteLine("Неверный ввод. Введите правильное целое неотрицательное число");

void raisedPower()
    {
    int count;
    double result = 1;
    for (count = 1; count <= power; count ++)
        {
        result = result * number;
        }
    Console.WriteLine($"Результат возвдения числа '{number}' в степень '{power}' - {result}.");
    return;
    }

raisedPower();