// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//78 -> 8
//12 -> 2
//85 -> 8
/*
int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}

int RandomNumber = new Random().Next(10, 100);

int result = FindBiggestDigit(RandomNumber);
Console.WriteLine($"Biggest digit of {RandomNumber} is {result}");
*/
/*
int CupNumber(int num)
{
    int ed = num % 10;
    int hund = num / 100;
    int res = hund * 10 + ed;
    return res;
}
int RandomNumber = new Random().Next(100, 1000);

int res = CupNumber(RandomNumber);
Console.WriteLine($"Искомое число {res}");
*/
/*
void IsDivisionable(int num1, int num2)
{
    if ( num2 % num1 == 0)
    {
        Console.WriteLine("-> Кратно");
    }
    else
    {
        Console.WriteLine($"-> Не кратно, остаток {num2 % num1}");
    }
}
Console.WriteLine("Input number1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(num1, num2);
*/
/*
bool TrueOrFalse (int num)
{
    if ( num % 7 == 0 && num % 23 == 0)
    return true;
    else return false;
}

Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsDivisionable = TrueOrFalse(num);
Console.WriteLine(IsDivisionable);
*/

void QuadOfNumbers (int num1, int num2)
{
    if ( num1 == num2 * num2 )
    {
        Console.WriteLine("-> Является квадратом");
    }
    else
    {
        Console.WriteLine("-> Не является квадратом");
    }
}
Console.WriteLine("Input number1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2 ");
int num2 = Convert.ToInt32(Console.ReadLine());

QuadOfNumbers( num1, num2);