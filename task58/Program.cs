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
MultiArray(array1, array2);



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

void MultiArray(int[,] array1, int[,] array2)
{
   int result = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int l = 0; l < array2.GetLength(1); l++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                for (int k = 0; k < array2.GetLength(0); k++) 
                {
 // и вот здесь пошла беда какая то, не могу понять как result в матрицу вернуть           
                result =result + array1[i,j+1]*array2[k+1,l]; 
                }
            } 
            
            Console.Write($"{result} \t");
            result = 0;
        }
        Console.WriteLine();
    }   
}

    


