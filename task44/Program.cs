/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Введите количество числел ряда Фиббоначи: ");

int numSize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numSize];
Fibbonaci(numSize);
PrintArray(array);
Console.WriteLine();

int[] Fibbonaci (int numSize)
{ 
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int i = 0;
    while(i < count)
    {
        Console.Write($"{array[i]} ");
        i++;
    }
}

