/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа. 78 -> 8 12-> 2 85 -> 8

*/

int GetRandomeNumberInRange(int minNumber, int maxNumber)
{
    int result = new Random().Next(minNumber, maxNumber + 1);
    return result;
}

int GetMaxDigitFromNumber (int number)
{
    int LeftNumber = number / 10;
    int RightNumber = number % 10;
    int result = 0;
    if (LeftNumber >= RightNumber)
    {
        result = LeftNumber;
    }
    if (LeftNumber < RightNumber)
    {
        result = RightNumber;
    }
    return result;
}
for (int i = 0; i < 10; i++)
{
   int randomeNumber = GetRandomeNumberInRange(10,99);
int MaxDigit = GetMaxDigitFromNumber(randomeNumber);
Console.WriteLine($"Набольшей цифрой числа {randomeNumber} является {MaxDigit}");
}

