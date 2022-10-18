/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.WriteLine("Введите количество x/y/z: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int height = rows;

int[,,] array = GetArray(rows, columns, height);
PrintArray(array);
Console.WriteLine();



int[,,] GetArray(int rows, int columns, int height)
{
    int[,,] matrix = new int [rows, columns, height];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           for (int m = 0; m < height; m++)
           {
            matrix[i, j, m] = new Random().Next(10,100);
           }
            
        }
    }
    return matrix;
}

void PrintArray( int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int m = 0; m < array.GetLength(2); m++)
           {
             Console.Write($"{array[i, j, m]}({i},{j},{m})  ");
           }
           
        }
        Console.WriteLine();
    }
}

