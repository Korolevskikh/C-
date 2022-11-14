/*Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N. 
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());;

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