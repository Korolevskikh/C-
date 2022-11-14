/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
 произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

Console.WriteLine("Введите количество строк 1 матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк 2 матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1);
Console.WriteLine("Матрица А:");
PrintArray(array1);
int[,] array2 = GetArray(rows2, columns2);
Console.WriteLine("Матрица В:");
PrintArray(array2);

Console.WriteLine();

Console.WriteLine("Матрица С=А*В:");
int[,] arr = MultiArray(array1, array2);
PrintArray(arr);



int[,] GetArray(int rows, int columns)
{
    int[,] matrix = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0,10);
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




int[,] MultiArray(int[,] array1, int[,] array2)
{
int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            result[i, j] = result[i, j] + array1[i, k] * array2[k, j];
        }
    }
}
return result;
}