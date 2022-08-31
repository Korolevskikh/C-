/*  Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). 
*/

string quoterRange(int quoter)
{
    string result = "нет данных";
    if (quoter == 1)
    {
        result = "диапазон X (0,+oo); Y (0,+oo)";
    }
    else if (quoter == 2)
    {
        result = "диапазон X (-oo, 0) и Y (0,+oo)";
    }
     else if (quoter == 3)
    {
       result = "диапазон X (-oo, 0) и Y (-oo, 0)";
    } 
    else if (quoter == 4)
    {
        result = "диапазон X (0, +oo) и Y (-oo, 0)";
    } 
    else 
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"ОШИБКА: неверно введена четверть");
        Console.ResetColor();
    }
   return result;
}
Console.WriteLine("Введите номер четверти:   ");
int quoter = Convert.ToInt32(Console.ReadLine());
string qR = quoterRange(quoter);
Console.WriteLine(qR);