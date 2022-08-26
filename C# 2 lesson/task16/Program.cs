/* Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет
*/
void CheckMultiple (int number1, int number2)
{
    if (number1*number1 == number2)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
Console.WriteLine("Введите первое число:  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2) 
{    
    CheckMultiple(number1, number2);
}
else
{
    CheckMultiple(number2, number1);
}


