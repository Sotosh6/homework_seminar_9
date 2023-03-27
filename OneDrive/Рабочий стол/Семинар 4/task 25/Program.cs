// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double numberB = Convert.ToInt32(Console.ReadLine());
double numberAInNumberBDegree (double number1, double number2)
{
    return Math.Pow(number1, number2);
}
double result = numberAInNumberBDegree (numberA, numberB);
Console.WriteLine($"Число A в степени B: {result}");