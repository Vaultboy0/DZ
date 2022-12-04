// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateRandomArray(int size, int size2, int minValue, int maxValue)
{
    int[,] newArray = new int[size, size2];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}
int[,] ShowArray(int[,] array)
{
    Console.WriteLine("Получившийся массив ->");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void Research(int a, int b, int[,] array)
{
    if (array.Length>=(a*b))
    {
        Console.WriteLine($"Элемент с индексами [{a},{b}] => {array[a-1, b-1]}");
    }
    else
    {
        Console.WriteLine($"В данном массиве нету элемента с индексами [{a},{b}]");
    }
}
void ArithmeticMean(int[,] array)
{
    Console.WriteLine("Среднее арифметическое стобцов данного массива => ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ =summ + array[j, i];
        }
        Console.Write($"{summ/array.GetLength(0)} ");
    }
}
Console.WriteLine("Введите количество cтрок");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandomArray(N, M, min, max);
ShowArray(myArray);
Console.WriteLine("Введите номер строки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int y1 = Convert.ToInt32(Console.ReadLine());
Research(x1, y1, myArray);
ArithmeticMean(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

