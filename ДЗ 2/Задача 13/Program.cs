/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число:  ");
int NumberX = 3;
string userNumber = Convert.ToString(Console.ReadLine());
Console.WriteLine(userNumber);
int count = userNumber.Length;

if (count < NumberX)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(&"Третья цыфра в числе: {userNumber[NumberX-1]}");
}