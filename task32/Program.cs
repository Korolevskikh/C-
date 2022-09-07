/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] array = GetArray(12, -9, 9);

int diferArray = 0;
Console.WriteLine();
foreach (int i in array)
{
 diferArray = - i; 
 Console.Write($"{diferArray} ");
}
Console.WriteLine();

