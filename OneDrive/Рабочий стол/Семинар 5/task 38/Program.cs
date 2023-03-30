// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double [] CreateArrayRndDouble(int size, double min, double max)
{
    double [] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100) + rnd.NextDouble();
        arr[i] = Math.Round(arr[i], 1);
    }
    return arr;
} 

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}; ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}

double GetMinElem(double[] arr)
{
    double minimal = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minimal) 
        {
            minimal = arr[i];
        }
    }
    return minimal;
}


double GetMaxElem(double[] arr)
{
    double maximal = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maximal) 
        {
            maximal = arr[i];
        }
    }
    return maximal;
}

Console.WriteLine("Введите размер массива: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(sizeOfArray, 0, 100);
PrintArray(array);

double getMinElem = GetMinElem(array);
double getMaxElem = GetMaxElem(array);

double sum = Math.Round(getMaxElem + getMinElem);
Console.WriteLine($"Минимальный элемент = {getMinElem:F1}");
Console.WriteLine($"Максимальный элемент = {getMaxElem:F1}");
Console.WriteLine($"Сумма минимального и максимального элемента массива = {sum}");
