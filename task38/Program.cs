/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double [] GetArray(int size)
{
    double [] res = new double[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(),3);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double [] array = GetArray(10);
double result = 0;

void MaxMinNumber (double [] array)
{
    double Max = array[0];
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]> Max)
        {
        Max = array[i];
        } 
        if (array[i]< Min)
        {
        Min = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine(Max);
    Console.WriteLine(Min);
    result = Max - Min;
}
MaxMinNumber(array);
Console.WriteLine($"Разница между Max и Min элементов массива = {result}"); 