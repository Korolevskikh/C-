/* Задача 63: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от 1 до N. 
N = 5 -> "1, 2, 3, 4, 5" 
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;


string Number(int m, int n)
{
    if (m<=n)
    {
        return $"{m} " + Number(m+1, n);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(Number(m,n));