// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите цифровую координату X точки А: ");
int AX;
while(!Int32.TryParse(Console.ReadLine(), out AX))
    Console.WriteLine("Введено неверно. Введите цифровую координату X точки А: ");

Console.WriteLine("Введите цифровую координату Y точки А: ");
int AY;
while(!Int32.TryParse(Console.ReadLine(), out AY))
    Console.WriteLine("Введено неверно. Введите цифровую координату Y точки А: ");

Console.WriteLine("Введите цифровую координату Z точки А: ");
int AZ;
while(!Int32.TryParse(Console.ReadLine(), out AZ))
    Console.WriteLine("Введено неверно. Введите цифровую координату Z точки А: ");

Console.WriteLine("Введите цифровую координату X точки B: ");
int BX;
while(!Int32.TryParse(Console.ReadLine(), out BX))
    Console.WriteLine("Введено неверно. Введите цифровую координату X точки B: ");

Console.WriteLine("Введите цифровую координату Y точки B: ");
int BY;
while(!Int32.TryParse(Console.ReadLine(), out BY))
    Console.WriteLine("Введено неверно. Введите цифровую координату Y точки B: ");

Console.WriteLine("Введите цифровую координату Z точки B: ");
int BZ;
while(!Int32.TryParse(Console.ReadLine(), out BZ))
    Console.WriteLine("Введено неверно. Введите цифровую координату Z точки B: ");

void distance (){

double dist = Math.Round(Math.Sqrt(Math.Pow((BX-AX),2)+Math.Pow((BY-AY),2)+Math.Pow((BZ-AZ),2)), 2);
Console.WriteLine($"A ({AX},{AY},{AZ}); B ({BX},{BY},{BZ}), -> {dist}")

}

distance (dist);