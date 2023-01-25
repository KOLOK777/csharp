// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void FillArray(int[] array)
    {
    Console.WriteLine($"Формируем массив из {array.Length} элементов");
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next();
    }
    return;
    }

void PrintArray(int[] array)
    {
    int i = 0;
    Console.Write($"Итоговый массив: [ {array[i]}");
    for (i = 1; i < array.Length; i++)
    {
    Console.Write($", {array[i]}");
    }
    Console.Write(" ]");
    return;
    }

FillArray(array);
PrintArray(array);