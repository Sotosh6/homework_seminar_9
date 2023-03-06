// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number/100;
int secondDigit = number/10 - firstDigit * 10;
Console.WriteLine($"Вывести вторую цифру от числа {number} -> {secondDigit}");