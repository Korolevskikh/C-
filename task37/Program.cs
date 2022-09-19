/* 
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] array = GetArray(8, 10, 100);
Console.WriteLine();

int SummNumber (int [] array)
{
int result = 0;

for (int i = 0; i < array.Length/2; i++)
    {
        if (array.Length%2 == 0)
        {
        result = array[i]*array[array.Length-i-1];
        Console.Write($"{result}  ");
        } 
        else
        {
            result = array[i];
            Console.Write($"{result}  ");
        }
    }
    return result;
}
SummNumber(array);


