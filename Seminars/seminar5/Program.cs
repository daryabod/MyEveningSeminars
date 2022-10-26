/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray [i] = new Random ().Next (minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    Console.WriteLine ($"Получившийся массив -> ");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}
void FindMinMaxSum (int [] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array [i] > 0) sumPositive += array [i];
        else sumNegative += array [i];
    }
    Console.WriteLine ($"Сумма положительных элементов -> {sumPositive} сумма отрицательных элементов -> {sumNegative}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMaxSum (myArray);
*/
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] myArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        myArray [i] = new Random ().Next (minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int [] array)
{
    Console.WriteLine ($"Получившийся массив -> ");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array [i] + " ");
    }
}
int [] ChangeElementsArray (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        array [i] = array [i] * -1;
    }
    return array;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(ChangeElementsArray(myArray));
*/
/*
int [] CreateNewArray(int size)
{
    int [] myArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        myArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void ShowArray (int [] array)
{
    Console.WriteLine ($"Получившийся массив -> ");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array [i] + " ");
    }
}
bool NeedlyElement (int [] array, int num)
{
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i]==num) return true;
    }
    return false;
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int [] NewArray = CreateNewArray (a);
bool result = NeedlyElement (NewArray, num);
ShowArray(NewArray);
Console.WriteLine($"В данном массиве есть указанное вами число? -> {result}");
*/

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] myArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        myArray [i] = new Random ().Next (minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int [] array)
{
    Console.WriteLine ($"Получившийся массив -> ");
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array [i] + " ");
    }
}
int ElementsCount (int [] array, int b, int c)
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array [i] >= 10 && array [i] <= 99)
        {
            count ++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало отрезка ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отрезка ");
int c = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = ElementsCount (myArray, b, c);
Console.WriteLine($"В этом массиве содержится {result} чисел от {b} до {c}");