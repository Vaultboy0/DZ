//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (num1>num2)
{
    Console.WriteLine($"{num1} > {num2}");
    max=num1;
    min=num2;
}
else
{
    Console.WriteLine($"{num2} > {num1}");
    max=num2;
    min=num1;
}
Console.WriteLine($"max number {max} and min number {min}");
*/
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 3");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
{
    if(num1>num3)
    {
        Console.WriteLine($"Max number {num1}");
    }
    else
    {
        Console.WriteLine($"Max number {num3}");
    }
}
else
{
    if(num2>num3)
    {
        Console.WriteLine($"Max number {num2}");
    }
    else
    {
        Console.WriteLine($"Max number {num3}");
    }
}
*/
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Enter number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1%2==0)
{
    Console.WriteLine($"Number {num1} even");
}
else
{
    Console.WriteLine($"Number {num1} not even");
}
*/
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*Console.WriteLine("Enter number N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Even number: ");
for(int i=0; i<numberN;i=i+2)
{
    Console.Write($" {i} ");
}
*/
