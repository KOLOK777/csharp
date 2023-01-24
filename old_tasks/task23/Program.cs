// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое число N: ");
int N;
while(!Int32.TryParse(Console.ReadLine(), out N))
    Console.WriteLine("Введено неверное значение, введите верное: ");

void CubePlus (int N)
    {
    int count = 1;
    Console.Write($"{N} -> {count}");
    count++;
    while (count <= N){
        Console.Write($", {Math.Pow(count, 3)}");
        count++;
        }
    }

void CubeMinus0 (int N)
    {
    int count = N;
    Console.Write($"{N} -> {Math.Pow(count, 3)}");
    count++;
    while (count <= 0){
        Console.Write($", {Math.Pow(count, 3)}");
        count++;
        }
    }

if (N <= 0)
    CubeMinus0(N);
else
    CubePlus(N);