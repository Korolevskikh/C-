/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomNumber(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber);
    return result;
}
int NumberBitwin(int number)
{
    int result = number / 10 % 10;
    return result;
}
int randomNumber = GetRandomNumber(100,1000);
int BitwinOneAndThree = NumberBitwin(randomNumber);
Console.WriteLine(randomNumber);
Console.WriteLine(BitwinOneAndThree);