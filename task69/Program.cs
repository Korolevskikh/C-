/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии. 
A = 3; B = 5 -> 243 (3⁵) 
A = 2; B = 3 -> 8
*/
//не совсем поняла, как на паре выполнили, поэтому решила как обычно

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());;


int ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result*a;
       
    }
    return result;
}
Console.WriteLine(ToDegree(a,b));