/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

*/
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] array = GetArray(100, 100, 1000);

int WhatEvenNumber(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
           result ++;
        }
        else { result = result + 0; }
    }
    return result;
   
}
Console.WriteLine($"Количество четных чисел = {WhatEvenNumber(array)}");
