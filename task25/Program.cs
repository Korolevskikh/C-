/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите числа А и В :  ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int Number = 1;
    for (int i = 1; i <= userNumber1; i++)
    {
            Number = Number * userNumber;
    }  
   
Console.WriteLine(Number);