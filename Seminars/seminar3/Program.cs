/*
int FindQuad ( double x, double y)
{
    if ( x > 0 && y > 0)
    return 1;
    if ( x < 0 && y > 0)
    return 2;
    if ( x < 0 && y < 0)
    return 3;
    if ( x > 0 && y < 0)
    return 4;

    return 0;

}

Console.WriteLine ("Input X:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Input Y:");
double y = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuad( x, y);
if (quadNum == 0)
{
    Console.WriteLine("Coordinats uncorrect");
}
else
{
    Console.WriteLine($"Point is located on {quadNum} quart");
}
*/
/*
void FindCoordinats(int quart)
{
    if (quart == 1)
    {
        Console.WriteLine("x + , y + ");
    }

     if (quart == 2)
    {
        Console.WriteLine("x - , y + ");
    }

     if (quart == 3)
    {
        Console.WriteLine("x - , y - ");
    }

     if (quart == 4)
    {
        Console.WriteLine("x + , y - ");
    }

    if (quart < 1 || quart > 4)

    Console.WriteLine("Quart incorrect");
}

Console.WriteLine("Input quart ");
int quart = Convert.ToInt32(Console.ReadLine());

FindCoordinats(quart);
*/
/*
double FindWay (double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
}

Console.WriteLine("Input xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb: ");
double yb = Convert.ToDouble(Console.ReadLine());

double findWay = FindWay(xa, xb, ya, yb);

Console.WriteLine($"Way = {findWay}");
*/

void quad (int num)
{
    int step = 1;

    while (step <= num)
    {
        Console.WriteLine($"квадрат числа {step} равен {step * step}");

        step++;
    }
}
Console.WriteLine("Input quart ");
int num = Convert.ToInt32(Console.ReadLine());

quad(num);