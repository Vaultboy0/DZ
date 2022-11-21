//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int digit2(int number)
{
    int chislo = number%100;
    chislo=chislo/10;
    return chislo;
}
Console.WriteLine($"Enter the number");
int number3=Convert.ToInt32(Console.ReadLine());
int numeric = digit2(number3);
Console.WriteLine($"Second digit of the number {number3} it {numeric}");
*/
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirdDigit(int digit)
{
    if(digit>=100)
    {
        while(digit>999)
        {
            digit=digit/10;
        }
        digit=digit%10;
        Console.WriteLine($"Third digit of a given number {digit}");
    }
    else
    {
        Console.WriteLine("There is no third number.");
    }
}
Console.WriteLine($"Enter the number");
int digit1=Convert.ToInt32(Console.ReadLine());
ThirdDigit(digit1);
*/
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool day_of_the_week(int day)
{
    if(day >= 6 && day <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine($"Enter the day of the week");
int DayWeek=Convert.ToInt32(Console.ReadLine());
if (DayWeek<8)
{
    bool days_of_the_weeks = day_of_the_week(DayWeek);
    if (days_of_the_weeks==true)
    {
        Console.WriteLine($"Day of the week {DayWeek} it day off");
    }
    else
    {
        Console.WriteLine($"Day of the week {DayWeek} it weekday");
    }
}
else
{
    Console.WriteLine($"There is no such day of the week");
}
*/

