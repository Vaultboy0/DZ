// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
 int[] ShowArray (int[] array)
 {
    Console.Write("Данный массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
    return array;
 }
 void ChetArray (int[] array) //вывод четных числе масива
 {
    Console.Write("Четные числа массива ->");
    for(int i=0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        {
        Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine("");
 }
 Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
ChetArray(myArray);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
 int[] ShowArray (int[] array)
 {
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
 }
 int SummNechet(int[] array) // сумма элементов на нечетных позициях
 {
    int summ=0;
    for(int i=1; i < array.Length; i+=2)
    {
        summ=summ+array[i];
    }
    return summ;
 }
 Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
int summ=SummNechet(myArray);
Console.WriteLine($"Сумма элементов нечетных позиций массива => {summ}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}
 int[] ShowArray (int[] array)
 {
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   // Console.WriteLine();
   return array;
 }
void min_and_max_value(int[] array)
{
    int max=array[0];
    int min=array[0];
    for(int i=1;i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
        if(min>array[i])
        {
            min=array[i];
        }
    }
    Console.WriteLine ($"Разница между минимальным и максимальным числом в массиве => {max-min}");
}
 Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
min_and_max_value(myArray);