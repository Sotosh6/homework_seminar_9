// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumOfDigits (int number1)
{
    if (number1 == 0)
        return 0;
    return (number1 % 10 + sumOfDigits (number1 / 10));
}
int result = sumOfDigits (number);
Console.WriteLine($"Сумма цифр в числе: {result}");