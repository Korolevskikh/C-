/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int []array = new int[8];

void FillArray(int[] range)
{
    int lenght = range.Length;
    int i = 0;
    while (i < lenght)
    {
        range[i] = new Random().Next(0,2);
        i++;
    }
}

void PrintArray(int[] ranges)
{
    int count = ranges.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(ranges[position]+" ");
        position++;
    } 
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
