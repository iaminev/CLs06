/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

double ReadANumber(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine()!;
    return Double.Parse(number);
}


double k1 = ReadANumber("Enter the value of k1 of function [y1 = k1*x + b1]: ");
double b1 = ReadANumber("Enter the value of b1 of function [y1 = k1*x + b1]: ");

double k2 = ReadANumber("Enter the value of k2 of function [y2 = k2*x + b2]: ");
double b2 = ReadANumber("Enter the value of b2 of function [y2 = k2*x + b2]: ");


System.Console.WriteLine($"y1 = {k1}*x + {b1}");
System.Console.WriteLine($"y2 = {k2}*x + {b2}");

if (k1 == k2 && b1 == b2)
{
    System.Console.WriteLine("The lines are the same - infinite intersections");
}
else if (k1 == k2)
{
    System.Console.WriteLine("The lines are paraller - NO intersections");
}
else
{
    string fmt = "0.000";
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"({x.ToString(fmt)}, {y.ToString(fmt)})");
}