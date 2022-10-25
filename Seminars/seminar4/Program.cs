/*
int FindSum (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i ++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Input A ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} -> {result}");
*/
/*
int FindSum(int num)
{
    int i = 1;
    for(i = 1; i <= num; i ++)
    {
        num = num/10;
    }
    return i;
}
Console.WriteLine("Input number ");
int a = Convert.ToInt32(Console.ReadLine());
int result = FindSum(a);
Console.WriteLine($"количество цифр в числе {a} -> {result}");
*/
/*
int FindProizv (int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int fact = FindProizv(num);
Console.WriteLine($"факториал числа {num} -> {fact}");
*/

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] myArray = new int [size];
    for (int i = 0; i < size; i ++)
    {
        myArray [i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}
void ShowArray (int [] array)
{
    Console.WriteLine("Получившийся массив ->");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array [i] + " ");
    }
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);