/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void DayWorkOrFree (int number)
{
    if (number > 5 & number < 8)
    {
        Console.WriteLine("Да");
    }
    else if (number > 0 & number <= 5)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Неверно введено число");
    }
}
Console.WriteLine("Введите число от 1 до 7:  ");
int number =Convert.ToInt32(Console.ReadLine());

DayWorkOrFree(number);