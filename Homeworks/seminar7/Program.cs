// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int [,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i ++)
        for ( int j = 0; j < columns; j ++)
        {
            newArray [i,j] = new Random().Next(minValue, maxValue + 1);
        }
        return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i ++)
    {
        for (int j = 0; j < array.GetLength (1); j ++)
        {
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Create2DRandomArray (m, n, min, max);
Show2DArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void Elements (int [,] array, int rows, int columns)
{   
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == num)
            {
                count = num;
            }
            
        }
    }
    if(num == count)
    {
        Console.WriteLine($"{num} -> такой элемент есть в массиве");
    }  
    else 
    Console.WriteLine($"{num} -> такого элемента нет в массиве");
   
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите свой элемент");
int num = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
Elements(myArray, num);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i ++)
        for ( int j = 0; j < columns; j ++)
        {
            newArray [i,j] = new Random().Next(minValue, maxValue + 1);
        }
        return newArray;
}

void Show2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i ++)
    {
        for (int j = 0; j < array.GetLength (1); j ++)
        {
            Console.Write (array [i,j] + " ");
        }
        Console.WriteLine();
    }
}
void AverageNumbers(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = average + array[i, j];
    }
   Console.Write($"{average/array.GetLength(0)}; ");
}
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
Console.Write("Среднее арифметическое каждого столбца: ");
AverageNumbers(myArray);