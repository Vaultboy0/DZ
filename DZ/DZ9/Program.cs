// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void InputNumber(int value)
// {
//     if(value!=0)
//     {
//         Console.Write($" {value} ");
//         return InputNumber(value--);
//     }
// }
// Console.WriteLine("Enter number N");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Набор натуральных числе от N до 1 => ");
// InputNumber(num1);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Summ(int summ, int N, int M)
{
    if(N!=M+1)
    {
        summ=summ+N;
        return Summ(summ,N+1,M);
    }
    else
    {
    return summ;
    }
}

Console.WriteLine("Enter number N");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number M");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма наутреальных элементов от M до N  => ");
int sum =Summ(0,num1,num2);
Console.Write(sum);
*/
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Accerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Accerman(n - 1, 1);
    }
    else
    {
        return (Accerman(n - 1, Accerman(n, m - 1)));
    }
}

Console.WriteLine("Enter number N");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number M");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Accerman(num1, num2);
Console.Write($"Число аккермана {result} ");
