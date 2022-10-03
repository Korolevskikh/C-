/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так: 
 1 4 7 2
 5 9 2 3
 8 4 2 4 
Новый массив будет выглядеть вот так: 
 1 4 7 2 
 5 81 2 9
 8 4 2 4  */

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк: ");
int columns = int.Parse(Console.ReadLine());

int[,] table = GetArray(rows, columns);
PrintArray(table);
Console.WriteLine();
PrintArray(ChangeArray(table));


int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
    return matrix;
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
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