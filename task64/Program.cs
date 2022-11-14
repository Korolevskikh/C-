/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());;

string Number(int m, int n)
{
    if (m<=n)
    {
        return $"{n} " + Number(m, n-1);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(Number(m,n));