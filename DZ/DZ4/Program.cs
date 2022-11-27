// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// void pow(double a, double b)
// {
//     Console.WriteLine($"Числа {a} в степени {b} => {Math.Pow(a,b)}"); Вариант через функцию возведения в степень
// }
/*
void pow(int a, int b)
{
    if(b!=0)
    {
    int result=a;
    for(int i=1; i<b;i++)
    {
        result=result*a;
    }
    Console.Write($"Числа {a} в степени {b} => {result} ");
    }
    else
    {
        Console.Write($"Числа {a} в степени {b} => {1}");
    }
}
Console.WriteLine($"ВВедите число которое нужно возвести в степень");
int digit1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите степень числа");
int digit2=Convert.ToInt32(Console.ReadLine());
pow(digit1,digit2);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int summ(int A)
{
    int result=0;
    while(A!=0)
    {
        result=result+A%10;
        A=A/10;
    }
    return result;
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int Summa=summ(a);
Console.WriteLine($"Сумма цифр числа {a} => {Summa}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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
 void ShowArray (int[] array)
 {
    Console.Write("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
   // Console.WriteLine();
 }
 Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a,min,max);
ShowArray(myArray);
*/