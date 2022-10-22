// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
 Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Decision (double xa, double xb, double ya, double yb, double za, double zb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
}

Console.WriteLine("Input xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input za: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

double segmentLength =  Math.Round (Decision(xa, xb, ya, yb, za, zb), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++) 
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
Console.WriteLine(" ");
*/