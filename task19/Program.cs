/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число:  ");
string userNumber = Convert.ToString(Console.ReadLine());
string Polindroom(string userNumber)
{
    string result = string.Empty;
    int length = userNumber.Length;
    if (length == 5)
    {
        if (userNumber[0] == userNumber[4] && userNumber[1] == userNumber[3])
        {
        result = "полиндром";
        }
        else
        {
        result = "не полиндром";
        }   
    }
    else
    {
        result = "не верно введено число";
    }
    return result;
}
string Poli = Polindroom(userNumber);
Console.WriteLine(Poli);



