// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое целое положительное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumberInterval(numberM, numberN);

void NaturalNumberInterval(int numberM, int numberN)
{
   if (numberM > numberN)
   {    
        Console.Write($"{numberM} ");
        NaturalNumberInterval(numberM -1 , numberN);
   }
   if (numberM < numberN)
   {    
        NaturalNumberInterval(numberM, numberN - 1);
        Console.Write($"{numberN} ");
   }
   if (numberM == numberN)
   {
        Console.Write($"{numberN}");
   }
}