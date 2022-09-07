/* Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна 
-20.
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
int [] array = GetArray(12, -9, 9);

int positiveSum = 0;
int negativeSum = 0;

foreach (int i in array)
{
    if (i > 0) { positiveSum += i; }
    else {negativeSum += i; }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {positiveSum}");
Console.WriteLine($"Сумма отрицательных чисел = {negativeSum}");