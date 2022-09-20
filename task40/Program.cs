/* 
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
              Теорема о неравенстве треугольника: каждая сторона треугольника 
              меньше суммы двух других сторон

*/
int number1 = 0;
int number2 = 0;
int number3 = 0;
Console.WriteLine("Введите 3 числа: ");
number1 = Convert.ToInt32(Console.ReadLine());
number2 = Convert.ToInt32(Console.ReadLine());
number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number2);
if (number1 < number2 + number3 && 
    number2 < number1 + number3 &&
    number3 < number2 + number1)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}