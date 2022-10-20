/*
Console.Write("Input first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"My first number is {num}");
*/

// здесь я вывожу мое первое число

// Задание 1. Напишите программу,которая на вход принимает число и выдает его квадрат (число умноженное само на себя).

// ** Например: **

//4 -> 16
//-3 -> 9
//-7 -> 49

/*
Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Quad of {num} is -> {result}");
*/

/*
Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);
while (current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

/*
Console.WriteLine("Input three-digit number ");
int num = Convert.ToInt32(Console.ReadLine());
int current= num % 10;
Console.Write(current);
*/

Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad2 = num2 * num2;
if ( num1 == quad2)
    Console.WriteLine($"{num1} является квадратом {num2}");
else Console.WriteLine($"{num1} не является квадратом {num2}");
