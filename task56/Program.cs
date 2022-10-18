/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Введите количество строк/столбцов массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows);
PrintArray(array);
Console.WriteLine();
int[] arr = FindSumRows(array, rows);
Console.WriteLine("Суммы строк, соответственно:");
PrintArr(arr);
FindMinSum(arr);


int[,] GetArray(int rows)
{
    int[,] matrix = new int[rows, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            matrix[i, j] = new Random().Next(0,10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
    Console.WriteLine();
    }
}

int[] FindSumRows(int[,] array, int rows)
{
    int[] sumRows = new int[rows];
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + array[i,j];

        }
        sumRows[i] = result;
        result = 0;
    }
    return sumRows;
}

void PrintArr(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       Console.Write($"{matrix[i]} \t");
    }
    Console.WriteLine();
}

void FindMinSum(int[] arr)
{
    int minNumber = arr[0];
    int rows = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
            rows = i;
        }
    }
    Console.WriteLine($"Минимальное значение среди сумм срок: {minNumber}");
    Console.WriteLine($"Строка с наименьшей суммой(при расчете от 0): {rows}");
}
