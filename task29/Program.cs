/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
*/

int[] array = new int[8];

void NewArray(int[]arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0,10);
        Console.Write($"{arr[i]} ");
    }
}

NewArray(array);
