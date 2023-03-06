// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер для недели:");
int number = Convert.ToInt32(Console.ReadLine());
bool checkNumber = CheckNumber(number);
Console.WriteLine(checkNumber == true ? "Да" : "Нет");

bool CheckNumber(int num)
{
    return num == 6 || num == 7;
}
