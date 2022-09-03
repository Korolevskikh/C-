/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

// Вычисление факториала
Console.WriteLine("Введите N:  ");
int N =int.Parse(Console.ReadLine());

double MultiNum(int N)
{
    int Mult =1;
    if (N > 0)
    {
        for (int i = 1; i <= N; i++)
    {
        Mult *=i;
    }
        return Mult;
    }
    else
    {
        Console.WriteLine("Неверно введено число (меньше заданного диапазона)");
        return 0;
    }
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {MultiNum(N)}");

