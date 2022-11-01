// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Create2DRandomArray(m, n, min, max);
Console.WriteLine();
Show2DArray(myArray);
Console.WriteLine();
SortToLower(myArray);
Show2DArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Строка с наименьшей суммой элементов: {minSumRow + 1} строка");
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Create2DRandomArray(m, n, min, max);
Console.WriteLine();
Show2DArray(myArray);
Console.WriteLine();
NumberRowMinSumElements(myArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void ProductMatrix(int[,] Martrix1, int[,] Martrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Martrix1.GetLength(1); k++)
      {
        sum += Martrix1[i,k] * Martrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
}
Console.WriteLine("Введите количество строк 1 матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Martrix1 = Create2DRandomArray(m, n, min, max);
Show2DArray(Martrix1);
Console.WriteLine();
int[,] Martrix2 = Create2DRandomArray(n, p, min, max);
Show2DArray(Martrix2);
int[,] result = new int[m,p];
ProductMatrix(Martrix1, Martrix2, result);
Console.WriteLine($"Произведение матриц");
Show2DArray(result);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNums = 89;

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] Matrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
{
  Matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
ShowArray(Matrix);