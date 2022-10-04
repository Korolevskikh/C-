/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца:");
FindSqrColumns(array);


int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
    }

void FindSqrColumns(int[,] array)
{
    double res = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
       
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
        }
        res = result/array.GetLength(0);
        Console.Write(Math.Round(res,2) + "; ");
    }
    Console.WriteLine();
}

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
