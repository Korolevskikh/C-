/* Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
*/
int GetRandomNumber(int minNumber, int maxNumber)
{
    int number = new Random().Next(minNumber, maxNumber);
    return number;
}
int randomNumber = GetRandomNumber(100,1000);
int result = 0;
int GetDigitFromNumber (int number)
{
    int LeftNumber = number / 100*10;
    int RightNumber = number % 10;
   
    result = LeftNumber + RightNumber;
    return result;
}
int DF = GetDigitFromNumber(randomNumber);
Console.WriteLine(randomNumber);
 Console.WriteLine(result);