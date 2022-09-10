/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int [] rang = new int[size];
    for (int i = 0; i < rang.Length; i++)
    {
        rang[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{rang[i]} ");
    }
        return rang;
}
int [] array = GetArray(123, 1, 500);

int WhatNumber(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>= 10 && array[i]<=99)
        {
           result ++;
        }
        else { result = result + 0; }
    }
    return result;
}
Console.WriteLine($"Количество  чисел = {WhatNumber(array)}");