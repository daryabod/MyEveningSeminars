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
double Distance (double xa, double xb, double ya, double yb, double za, double zb)
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

double dist =  Distance (xa, xb, ya, yb, za, zb);

Console.WriteLine($"Distance {dist}");
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void cubes (int N)
{
    int num=1;
    while (num <= N)
    {
        double cube = Math.Pow(num,3 );
        Console.WriteLine ( cube );
        num++;
    }
}

Console.Write ("Input number N ");
int N = Convert.ToInt32(Console.ReadLine());
cubes(N);
*/
