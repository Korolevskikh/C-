/*
Задача 46: Задайте двумерный массив размером m×n,заполненный случайными целыми числами. 
m = 3, n = 4. 
1 4 8 19
5 -2 33 -2 
77 3 8 1 */
//НЕ МОГУ ПОНЯТЬ: ПОЧЕМУ ВЫДАЕТ ОШИБКУ System.Int32[,] ?

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] table = GetArray(rows, columns, -100, 100);
PrintArray(table);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] table = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            table[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    Console.WriteLine(table);
return table;
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i,j]} ");
        }
        Console.WriteLine();
    }
}