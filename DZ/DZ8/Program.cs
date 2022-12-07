// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateArray(int size, int size2, int minValue, int maxValue)
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
    Console.WriteLine("Текущий массив  ->");
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

int[,] Sortirovka(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp=0;
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,j]<array[i,k])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,k];
                    array[i,k]=temp;
                }
            }
        }
    }
    Console.WriteLine("Отсортированный массив");
    ShowArray(array);
    return array;
}
int[,] SummaValueStrok(int[,] array)
{
    int count=0;
    int summ=9999999;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int TempSumm=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            TempSumm=TempSumm+array[i,j];
        }
        if(summ>TempSumm)
        {
            summ=TempSumm;
            count=i+1;
        }
    }
    Console.WriteLine($"Cумма наименьшей строки {summ} это строка номер {count} ");
    return array;
}
Console.WriteLine("Введите количество cтрок");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(N, M, min, max);
ShowArray(myArray);
Sortirovka(myArray);
SummaValueStrok(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateArray(int minValue, int maxValue)
{
    int[,] newArray = new int[2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}
int[,] ShowArray(int[,] array)
{
    Console.WriteLine("Текущий массив  ->");
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
int[,] ProisMatrix(int[,] array1, int [,] array2)
{
    int[,] NewArray=new int [2,2];
    NewArray[0,0]=(array1[0,0]*array2[0,0])+(array1[0,1]*array2[1,0]);
    NewArray[0,1]=(array1[0,0]*array2[0,1])+(array1[0,1]*array2[1,1]);
    NewArray[1,0]=(array1[1,0]*array2[0,0])+(array1[1,1]*array2[1,0]);
    NewArray[1,1]=(array1[1,0]*array2[0,1])+(array1[1,1]*array2[1,1]);
    return NewArray;
}
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateArray(min, max);
int[,] myArray2 = CreateArray(min,max);
ShowArray(myArray);
Console.WriteLine("Второй массив");
ShowArray(myArray2);
int[,] matrix=ProisMatrix(myArray,myArray2);
ShowArray(matrix);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
/*
int[,,] CreateArray(int size, int size2, int size3)
{
    Console.WriteLine("Напишите двухзначные не повторяющиеся значения для массива");
    int[,,] newArray = new int[size, size2, size3];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            int temp=0;
            for (int k = 0; k < size3; k++)
            {
                newArray[i,j,k]=Convert.ToInt32(Console.ReadLine());
                temp=newArray[i,j,k];
            }
        }
    }
    return newArray;
}

int[,,] ShowArray(int[,,] array)
{
    Console.WriteLine("Текущий массив  ->");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $" ({i+1},{j+1},{k+1}) ");
            }
        }
        Console.WriteLine();
    }
    return array;
}
Console.WriteLine("Введите количество cтрок");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нумерацию в Z пространстве");
int Z = Convert.ToInt32(Console.ReadLine());
int[,,] myArray = CreateArray(X, Y, Z);
ShowArray(myArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Задачу мог решить конкретно под текущий 4 на 4, но мне хотелось сделать универсальный. Поэтому пошел искать алгоритмы в интернете. В целом я понял, что они делали. 
//Они в целом помогли мне обойти свитч конструкцией для разворота из 3 строк. Полагаю, что я бы дошел до этой формулы много позже, сперва поигравшись бы с фиксированными значениями, чтобы потом выразить это через формулы. 
int[,] CreateArray(int size1, int size2) // Сделан по правилу правой руки с выходом из лабиринта грубо говоря.
{
    int[,] NewArray = new int[size1, size2];
    int x = 0; // индекс по строке
    int y = 0; // индекс по столбцу
    int dx = 1; // переменные для будущего разворота по часовой стрелке
    int dy = 0;
    int dirChanges = 0; // для изменения значения посещения, чтобы не натыкаться на уже заполненные индексы.
    int visits = size2;
    for (int i = 0; i < NewArray.Length; i++) // идем по массиву используя индекс для его заполнения. 
    {
        NewArray[x, y] = i + 1;
        visits--; // уменьшаем посещение на единичку за каждый проход, чтобы знать сколько мы еще можем идти по текущему маршруту, чтобы не выйти за пределы массива
        if (visits == 0)  // если уменьшая посещение мы свели его до нуля перерасчитываем его под новые показатель, чтобы определить сколько нам нужно пройти с учетом уже заполненных частей
        {
            visits = size2 * (dirChanges % 2) + size1 * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2; // здесь идет перерасчет посещений. Поскольку мы берем сложение последних индексов по х и у массива, а не поэлементно, то нам нужны будут два размера изначальных
            // которые мы меняем в соответствиии с уже случившимимся поворотами, чтобы ограничить наш проход не вылезая на заполненные значения. 
            int temp = dx; //переключение по часовой стрелке для заполнения массива 
            dx = -dy; 
            dy = temp;
            dirChanges++;
        }
        y += dx; // увеличиваем индексы по соответствующим колонкам, чтобы потом развернуть их. 
        x += dy;
    }
        return NewArray;
}
    int[,] ShowArray(int[,] array)
    {
        Console.WriteLine("Текущий массив  ->");
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
    Console.WriteLine("Введите количество cтрок");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int M = Convert.ToInt32(Console.ReadLine());
    int[,] myArray = CreateArray(N, M);
    ShowArray(myArray);

