/* 
Найдите сумму элементов, стоящих на нечётных позициях (по индексу считаем).
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int WhatSumNumberOddindex(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1)
        {
          result = result + array[i];
        }
        else { result = result + 0; }
    }
    return result;
   
}
Console.WriteLine($"Сумма чисел нечетных индексов = {WhatSumNumberOddindex(array)}");