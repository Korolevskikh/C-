/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший 
элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7 */

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = GetArray(rows, columns, -10, 10);
PrintArray(arr);
Console.WriteLine();
int[] minPosition = FindNamber(arr);
int[,]  array = NewArray(arr, minPosition);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          array[i,j] = new Random().Next(minValue,maxValue);  
        }
    }
    return array;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindNamber(int[,] array)
{
     int[] result = new int[2];
     int minNumber = array[0, 0];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] <= minNumber)
            {
                minNumber = array[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    Console.WriteLine(minNumber);
    Console.WriteLine($"{result[0]}, {result[1]}");
    return result;
}

int[,] NewArray(int[,] array, int[] minPosition)
{
    int[,] matrix = new int[array.GetLength(0)-1, array.GetLength(1) -1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       if(i == minPosition[0]) continue;
       {
         for (int j = 0; j < array.GetLength(1); j++)
            {
            if (j == minPosition[1]) continue;
                {
                 matrix[k,l] = array[i,j];   
                l++;
                }
            }
            k++;
            l = 0;
        }
    }
    return matrix;
}