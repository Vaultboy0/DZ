// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrom (int a)
{
    int number1=(a%100)/10;
    Console.WriteLine($" {number1} ");
    int number2=(a/1000)%10;
    Console.WriteLine($"{number2}  ");
    if(number1==number2) 
    {
        Console.WriteLine($"Число {a}  палиндром");
    }
    else
    {
        Console.WriteLine($"Число {a} не палиндром");
    }
}
Console.WriteLine($"Enter the number");
int digit1=Convert.ToInt32(Console.ReadLine());
Palindrom(digit1);
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
void distance(double x1, double y1, double z1, double  x2, double y2, double z2)
{
    //double d=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    //Console.WriteLine($"Расстояние между двумя точками а1 и а2 в 3д пространстве => {d}");
    Console.WriteLine($"Расстояние между двумя точками а1 и а2 в 3д пространстве => {Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2))}");
}
Console.WriteLine($"Введите координату х для точки 1");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите координату y для точки 1");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите координату z для точки 1");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите координату х для точки 2");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите координату y для точки 2");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите координату z для точки 2");
double z2=Convert.ToDouble(Console.ReadLine());
distance(x1,y1,z1,x2,y2,z2);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void cub(int n)
{
    int result;
    Console.WriteLine($"Таблица кубов числа {n} => ");
    for(int i=1;i<=n;i++)
    {
        result=i*i*i;
        Console.Write($" {result} ");
    }
}
Console.WriteLine($"Enter the number N");
int digit1=Convert.ToInt32(Console.ReadLine());
cub(digit1);
*/