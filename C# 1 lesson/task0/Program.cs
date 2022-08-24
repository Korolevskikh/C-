/*
 Напишите программу, которая на вход принимает число и выдаёт 
 его квадрат (число умноженное на само себя).
*/ 

int usernumber = new int();
Console.WriteLine("Введите число: ");
usernumber = Convert.ToInt32(Console.ReadLine()); 

int result = usernumber * usernumber;
Console.WriteLine($"Степень числа {usernumber} = {result}");