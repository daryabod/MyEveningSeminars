// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] UserNumbers(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void GetCountNumbersInString (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше нуля -> {count}");
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int [] newArray = UserNumbers(a);
ShowArray(newArray);
GetCountNumbersInString(newArray);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void IntersectionPoints(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
        if(k1 == k2)
        {
            Console.WriteLine("Прямые не имеют точку пересечения");
        }
        else Console.WriteLine($"Прямые пересекаются в точке -> ({x};{y})");
} 
Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoints(b1, k1, b2, k2);
*/