// Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double y, x;
double a = b1 - b2;
double b = k2 - k1;

if (b != 0)
{
    x = a / b;
    y = k1 * x + b1;

    Console.WriteLine("Прямые пересекаются в точке (" + x + "; " + y + ")");
}
else Console.WriteLine("Просьба проверить значения, нет возможности делить на 0");