// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNumbers(int n)
{
    if(n <= 0)
    {
        Console.WriteLine($"{n} <- не натуральное число");
    }
    Console.Write(" " + n);
    if (n > 1) ShowNumbers(n-1);
            
}
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int n, int m)
{
    if(n > m)
    {
	    SumNumbers(n-1, m); 
	}
	return (n + m)*(n - m + 1)/2; 
}
		
Console.WriteLine(SumNumbers(7, 2));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int FunctionAkkermana(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else 
        if (n == 0 && m > 0)
        {
            return FunctionAkkermana(m - 1, 1);
        }
    else
    {
        return (FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1)));
    }
}

Console.Write(FunctionAkkermana(3, 2));