// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 5 -> Пятница
int userNumber = new int();
Console.WriteLine("Введите число от 1 до 7: ");
userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber<=0 || userNumber>7)
{Console.WriteLine("Данное число не входит в диапазон");}
if (userNumber == 1) {    Console.WriteLine("Понедельник");}
else if (userNumber == 2) {    Console.WriteLine("Вторник");}
else if (userNumber ==3) {    Console.WriteLine("Среда");}
else if (userNumber ==4) {    Console.WriteLine("Четверг");}
else if (userNumber ==5) {    Console.WriteLine("Пятница");}
else if (userNumber ==6) {    Console.WriteLine("Суббота");}
else if (userNumber ==7) {    Console.WriteLine("Воскресенье");}