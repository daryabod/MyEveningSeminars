/*
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
}
int [] ReverseArray (int [] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array [i];
        array [i] = array [array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
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
ShowArray(ReverseArray(myArray));
*/
/*
bool bam (int x, int y, int z)
{
    if (x + y > z && y + z > x && x + z > y)
    return true;
    else return false;
}
Console.WriteLine("Input x number ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y number ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z number ");
int z = Convert.ToInt32(Console.ReadLine());

bool result = bam (x, y, z);
if (result == true)
{
    Console.WriteLine ($"Треугольник со сторонами {x} {y} {z} может существовать");
}
else
Console.WriteLine ($"Треугольник со сторонами {x} {y} {z}  не может существовать");
*/
/*
int [] Ciferka (int n, int a, int b)
{
    int [] myArray = new int [n];
    myArray [0] = a;
    myArray [1] = b;
    for (int i = 2; i < n; i++)
    {
        myArray [i] = myArray [i - 1] + myArray [i - 2];
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
}
Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n ");
int n = Convert.ToInt32(Console.ReadLine());
ShowArray(Ciferka (n, a, b));
*/

void ConvertTo2 (int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num = num/2;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
ConvertTo2(num);