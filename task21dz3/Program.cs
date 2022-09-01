/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 
 */
 int userXa = 0;
 int userXb = 0;
 
 int userYa = 0;
 int userYb = 0;
 
 int userZa = 0;
 int userZb = 0;
 Console.WriteLine("Введите координаты точки А:  ");
 userXa = Convert.ToInt32(Console.ReadLine());
 userYa = Convert.ToInt32(Console.ReadLine());
 userZa = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты точки В:  ");
 userXb = Convert.ToInt32(Console.ReadLine());
 userYb = Convert.ToInt32(Console.ReadLine());
 userZb = Convert.ToInt32(Console.ReadLine());

 double distantXY(int userXa, int userXb, int userYa, int userYb, int userZa, int userZb)
 {
    int resultX = 0;
    resultX = userXb - userXa;
    int resultY = 0;
    resultY = userYb - userYa;
       int resultZ = 0;
    resultZ = userZb - userZa;
    double result = Math.Sqrt(Math.Pow(resultX,2) + Math.Pow(resultY,2)+ Math.Pow(resultZ,2));
    return result;
 }
 double dis = distantXY(userXa, userXb, userYa, userYb, userZa, userZb);
 Console.WriteLine(Math.Round(dis, 2));