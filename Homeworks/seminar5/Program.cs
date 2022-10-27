// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(100, 1000);
    }
    return myArray;
}

void FillArrayRandomNumbers(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void PrintArray(int[] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        amount++;
    }
    Console.WriteLine($"Количество четных чисел -> {amount}");
}
Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a);
FillArrayRandomNumbers(myArray);
PrintArray(myArray);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив ->");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void FindSumOddNumber(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        if (i % 2 != 0)
        sumOdd = sumOdd + array[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {sumOdd}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = RandomArray(a, min, max);
ShowArray(myArray);
FindSumOddNumber(myArray);
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}
void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
void FindMinMaxNumber(int[] array)
{
    int diff = 0;
    int max = array[0];
    int min = array[0];
    for(int i = 1; i < array.Length;i++)
    {
        if(array[i]>max) max = array[i]; 
    }
    for(int i = 1; i < array.Length;i++)
    {
        if(array[i]<min) min = array[i]; 
    }
    diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {(diff)}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxNumber(myArray);