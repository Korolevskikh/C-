/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:  ");
int userNumber = Convert.ToInt32(Console.ReadLine());

   int userNumber0 = userNumber / 10000;
    int userNumber4 = userNumber % 10;
    int userNumber1 = (userNumber / 1000) % 10;
    int userNumber3 = (userNumber % 100) / 10;
    if (userNumber > 9999 && userNumber < 100000)
    {
        if (userNumber0 == userNumber4 && userNumber1 == userNumber3)
        {
        Console.WriteLine("&{userNumber} - полиндром");
        }
        else
        {
        Console.WriteLine("&{userNumber} - не полиндром");
        }   
    }
    else
    {
         Console.WriteLine("не верно введено число");
    }