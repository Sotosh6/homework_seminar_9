// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int number1 = UserInput("Введите первое число: ");
int number2 = UserInput("Введите второе число: ");
NaturalNumberTotal(number1, number2);
int total = NaturalNumberTotal(number1,number2);
Console.WriteLine($"Сумма всех чисел в промежутке между {number1} и {number2} равна: {total}");

int NaturalNumberTotal(int num1, int num2)
{               
    if (num1 == num2) return num1;

    else if (num1 < num2) return num2 + NaturalNumberTotal(num1, num2 - 1);

    else return num2 + NaturalNumberTotal(num1, num2 + 1);            
}


int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}