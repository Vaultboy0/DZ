// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 /*
int CorrectValue() 
{
    int value;
    while (!int.TryParse(Console.ReadLine(), out value)) //проверка, что введение значение число, а не символы
    {
        Console.WriteLine("Ошибка ввода! Введите целое число ");
    }
    return value;
}
int[] CreateArray (int size)
{
   int [] newArray  = new int [size];
   for(int i=0; i < size; i++)
   {
    newArray[i] = CorrectValue();
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
int CountBigZero(int[] array)       
{
    int count=0;
    for(int i=0; i<array.Length;i++)
    {
        if(array[i]>0) count++;
    }
    return count;
}
Console.WriteLine("Сколько чисел вы будете вводить? ");
int a = CorrectValue();
int[] myArray = CreateArray(a);
ShowArray(myArray);
Console.WriteLine($"Количество числе больше нуля в данном массиве данных => {CountBigZero(myArray)}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 /*
double PointX(double k1, double b1, double k2, double b2) // поиск точки х
{
    return ((-b2 + b1)/(-k1 + k2));
}
double PointY(double X, double k2, double b2) // поиск точки y
{
    return (k2 * X + b2);
}
Console.WriteLine("Введите значение k1");
double k1= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
// double x=PointX(k1,b1,k2,b2);
// double y=PointY(x,k2,b2);
// Console.WriteLine($"Точка пересечения для двух прямых  => {x} ; {y}");
Console.WriteLine($"Точка пересечения для двух прямых =>  {PointX(k1,b1,k2,b2)} ; {PointY(PointX(k1,b1,k2,b2),k2,b2)}"); // через вывод без переменных
*/