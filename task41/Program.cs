/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите количество чисел для анализа M = ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
GetArray(array);

void GetArray(int[] res)
{
    for (int i = 0; i < res.Length; i++)
    {
    Console.WriteLine($"Введите {i} элемент массива: ");
    res[i] = Convert.ToInt32(Console.ReadLine());
    } 
}
Console.Write(String.Join(" ", array));
Console.WriteLine();

void CountGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        count++ ;
        }
    }
   Console.WriteLine($"Количество чисел больше нуля: {count}");
}
CountGreaterZero(array);

