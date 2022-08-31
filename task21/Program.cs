/*
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве. A (3,6); B (2,1) -> 5,09 A (7,-5);
 B (1,-1) -> 7,21 
 */
 int userXa = 0;
 int userXb = 0;
 int userYa = 0;
 int userYb = 0;
 Console.WriteLine("Введите координату Xa:  ");
 userXa = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату Ya:   ");
 userYa = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату Xb:  ");
 userXb = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координату Yb:   ");
 userYb = Convert.ToInt32(Console.ReadLine());

 double distantXY(int userXa, int userXb, int userYa, int userYb)
 {
    int resultX = 0;
    resultX = userXb - userXa;
    int resultY = 0;
    resultY = userYb - userYa;
    double result = Math.Sqrt(Math.Pow(resultX,2) + Math.Pow(resultY,2));
    return result;
 }
 double dis = distantXY(userXa, userXb, userYa, userYb);
 Console.WriteLine(Math.Round(dis, 2));