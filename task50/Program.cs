/* Задача 50: Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
*/

Console.WriteLine("введите количество строк в 2хмерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов в 2хмерном массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите позицию для поиска в 2хмерном массиве: ");
int position = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
FindNamber(array);
Console.WriteLine(FindNamber(array));
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int FindNamber(int[,] array)
{
int rows1 = position/10;
int columns1 = position%10;
int result = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == rows1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == columns1)
            {
            result = array[i, j];
            }
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}