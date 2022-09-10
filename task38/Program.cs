/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] array = GetArray(10, 100, 1000);


int MaxMinNumber (int [] array)
{
    int Max = array[0];
    int Min = array[0];
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
    return Max - Min;
}
Console.WriteLine($"Разница между Max и Min элементов массива = {MaxMinNumber(array)}");