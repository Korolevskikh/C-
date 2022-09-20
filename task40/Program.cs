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

string result;
result = Delta(number1, number2, number3);
Console.WriteLine(result);

string Delta(int number1, int number2, int number3)
{
    string result = string.Empty;
   if (number1 < number2 + number3 && 
    number2 < number1 + number3 &&
    number3 < number2 + number1)
{
    result = "Треугольник существует";
}
else
{
    result = "Треугольник не существует";
} 
return result;
}
