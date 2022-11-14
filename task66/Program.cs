/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.WriteLine("Введите число:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum (int m, int n)
{
    if (m<=n && m%2==0 )
    {
        return m + Sum(m+2,n);
    }
    else
    {
        return 0;
    }
}
Console.WriteLine(Sum(m, n));