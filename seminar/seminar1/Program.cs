/*
int FindBiggtstDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if(ed>dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}
int rand = new Random().Next(10,100);
Console.WriteLine($"Your number -> {rand}"); // Вывод нашего числа
int result = FindBiggtstDigit(rand);
Console.WriteLine($"The biggest Digit -> {result}"); // Вывод большего из двух
*/
/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int res = sot*10+ed;
    return res;
}
int rand = new Random().Next(100,1000);
int newNumber = CutNumber(rand);
Console.WriteLine($"New version of {rand} is {newNumber}");
*/

