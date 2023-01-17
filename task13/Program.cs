// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int bit = 1000;

if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
while (number / bit == 0)
        bit = bit * 10;
        
Console.WriteLine(bit);
int digit = number % (bit / 100);       
Console.WriteLine(digit);