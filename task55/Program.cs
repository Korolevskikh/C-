/* Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя. */

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows == columns)
{
   int[,] array = GetArray(rows, columns);
    PrintArray(array);
    Console.WriteLine();
    int[,] arr = ChangeArray(array);
    PrintArray(arr);
}
else
{
    Console.WriteLine("Невозможно произвести замену");
}



int[,] GetArray(int m, int n)
{
    int[,] matrix = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1,15);
        }
    }
    return matrix;
}

void PrintArray( int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = i; j < array.GetLength(1); j++)
    {
        int change = array[i,j];
        array[i,j] = array[j, i];
        array[j, i] = change;
    }
   
    }
    return array;
}