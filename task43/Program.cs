/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

Console.WriteLine("Введите коэфициенты для уравнения1 b1 и k1, соответственно: ");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициенты для уравнения2 b2 и k2, соответственно: ");
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
double a = b2 - b1;
double c = k1 - k2;
double x = a / c;

double y = k1*x + b1;
Console.WriteLine(a);
Console.WriteLine(c);
Console.WriteLine(x);
Console.Write($"Координаты точки пересечения прямых: {Math.Round(x, 2)} ; {Math.Round(y,2)}");
Console.WriteLine();
