/*
Задача 51: Задайте двумерный массив. Найдите элементы, находящихся на главной 
диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив: 
1 4 7 2
 5 9 2 3 
8 4 2 4 
Сумма элементов главной диагонали: 1+9+2 = 12 
*/


Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine("Сумма элементов главной диагонали равна " + FindSumDiagonale(array));

int[,] GetArray(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(-10, 10);
        }
    }
    return table;
}

int FindSumDiagonale(int[,] array)
{
    int result = 0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j)
            {
                result = result + array[i,j];
            }
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}