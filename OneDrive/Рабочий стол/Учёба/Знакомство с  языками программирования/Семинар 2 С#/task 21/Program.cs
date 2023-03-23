// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X точки А: ");
int xFromPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int yFromPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: "); 
int zFromPointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
int xFromPointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int yFromPointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int zFromPointB = Convert.ToInt32(Console.ReadLine());

int segment1 = xFromPointB - xFromPointA;
int segment2 = yFromPointB - yFromPointA;
int segment3 = zFromPointB - zFromPointA;

double lengthWithOutRound = Math.Sqrt(segment1*segment1 + segment2*segment2 + segment3*segment3);
double lengthWithRound = Math.Round(lengthWithOutRound, 2);
Console.WriteLine($"Длина отрезка {lengthWithRound}");
