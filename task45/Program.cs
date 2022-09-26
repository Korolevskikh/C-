/*
Задача 45: Напишите программу, которая будет создавать копию заданного
 массива с помощью поэлементного копирования.
*/

int[] array = GetArray(10,0,100);
Console.WriteLine(String.Join(" ", array));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArr[i] = array[i];
        Console.Write($"{copyArr[i]} ");
    }
}
CopyArray(array);