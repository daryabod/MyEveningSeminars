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

int [,] ShowQuad (int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i ++)
    {
        for (int j = 0; j < array.GetLength (1); j ++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                array [i,j] *= array [i,j];
            }
        }
    }
    return array;
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
Console.WriteLine();
Show2DArray(ShowQuad(myArray));
*/
/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int numbersSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + array[i, j];
        }
        Console.WriteLine();
    }
    return sum;
}
Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m, n, minValue, maxValue);
Show2DArray(myArray);
int result = numbersSum(myArray);
Console.WriteLine(result);
*/

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
