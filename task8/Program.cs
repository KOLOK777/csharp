// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int N;
while (!Int32.TryParse(Console.ReadLine(), out N))
    {   
    Console.WriteLine("Ввод неверный. Пожалуйста, введите корректное число");
    }
int helpN = N;
int count = 4;

Console.WriteLine("ИТОГ (выводим четные числа):");

if (N == 1)
    {
    Console.WriteLine("в промежутке нет четных чисел !");       
    }
if (N > 1) 
    {    
    Console.Write(count-2);
    }
    while (count <= N)
    {
    Console.Write(", " + count);
    count = count + 2;
    }
if (N < -2)
    if (N % 2 !=0)
        {
        helpN = N + 1;
        }       
    while (helpN <= 0)
        if (helpN != 0)
            {
            Console.Write(helpN + ", ");
            helpN = helpN + 2;
            }
        else
            {
            Console.Write(helpN);
            helpN = helpN + 2;
            }
