/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент 
входных данных.*/

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = FillArray(rows, columns, 0, 10);
PrintArray(arr);
FindNamber(arr, 10);
    


int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
          array[i,j] = new Random().Next(minValue,maxValue);  
        }
    }
    return array;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void FindNamber(int[,] arr, int maxValue)
{
    
    for (int k = 0; k < maxValue; k++)
    
    {
        int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] == k)
             {
                count++;
             }   
        } 
    }
    Console.WriteLine($"{k} встречается {count} раз");
    }
}