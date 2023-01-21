// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int number;
while (!Int32.TryParse(Console.ReadLine(), out number))
    {   
    Console.WriteLine("Ввdод неверный. Пожалуйста, введите корректное число");
    }
int helpNumber = number;

if (number < 100 && number > -100)
{
    Console.WriteLine("В вашем числе (" + number + ") третьей цифры нет");
}
else 
{
    while (helpNumber >= 1000 || helpNumber <= -1000)
    {
        helpNumber = helpNumber / 10;
    }
    helpNumber = helpNumber % 10;       
    Console.WriteLine("Третья цифра в вашем числе (" + number + ") : " + Math.Abs(helpNumber));
}