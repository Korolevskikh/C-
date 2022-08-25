/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("проверим четное или нечетное число  ");
Console.WriteLine("Введите число:  ");
double Number = Convert.ToInt32(Console.ReadLine());
if  (Number % 2 == 0)
{
    Console.WriteLine("Да. Это четное число");
}
else
{
    Console.WriteLine("Нет. Это нечетное число");
 }