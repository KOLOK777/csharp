// 


Console.WriteLine("Введите цифру, обозначающую день недели");
int number;
while (!Int32.TryParse(Console.ReadLine(), out number) || number > 7 || number < 1)
    {
    Console.WriteLine("Ввdод неверный. Пожалуйста, введите корректное число");
    }