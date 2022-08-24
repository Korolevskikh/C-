// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли второе число квадратом первого. 
// a = 25, b = 5 -> да a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

int userNumber1 = new int();
Console.WriteLine("Введите первое число: ");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = new int();
Console.WriteLine("Введите второе число: ");
userNumber2 = Convert.ToInt32(Console.ReadLine());
    if (userNumber2 == userNumber1*userNumber1)
    {
         Console.WriteLine("да");
    }
   else
    {
          Console.WriteLine("Нет");
    }

