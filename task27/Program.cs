/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
в числе. 452 -> 11     82 -> 10      9012 -> 12
*/

Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine());

int SumNumber (int number)
{
int length = userNumber.ToString().Length;
int result = 0;
for (int i = 0; i < length; i++)
    {
     int res1 = userNumber%10;
     userNumber = userNumber / 10;
     result = result + res1;
    }
return result;
}
Console.WriteLine($"Сумма цифр числа {userNumber} = {SumNumber(userNumber)}");