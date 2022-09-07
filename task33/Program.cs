/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int [] array = new int[10];

void NewArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = new Random().Next(0,10);
        Console.Write($"{arr[i]} ");
    }
    
    Console.WriteLine();
}
NewArray(array);

int FindArray(int[] collection, int find)
{
int result = 0; 
for (int i = 0; i < collection.Length; i++)
    {
    
    if (collection[i] == find) { result = 1;}
    }
    return result;
}


Console.WriteLine("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());

int res = FindArray(array, find);

if (res == 1)
{
    Console.WriteLine($"Число {find} присутствует в массиве");
}
else {Console.WriteLine($"Число {find} отсутствует в массиве");}
