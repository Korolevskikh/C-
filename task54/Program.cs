/* Задача 54: Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива.*/

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
int[,] arr = ChangeArray(array);
PrintArray(arr);


int[,] GetArray(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0,15);
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = j+1; k < array.GetLength(1); k++)
           {
            if (array[i,k] > array[i,j])
                {
                int change = array[i,k];
                array[i,k] = array[i,j];
                array[i,j] = change;
                }
           }  
        }
    } 
    return array;
}

