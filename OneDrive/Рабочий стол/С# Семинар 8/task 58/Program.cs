// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  // 0, 1
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// int[,] CreateMatrixTwoRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrixTwo = new int[rows, columns];  // 0, 1
    
//     Random rnd = new Random();

//     for (int i = 0; i < matrixTwo.GetLength(0); i++)
//     { 
//         for (int j = 0; j < matrixTwo.GetLength(1); j++)
//         {
//             matrixTwo[i,j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrixTwo;
// }
 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j], 5} ");
    }
    Console.WriteLine("|");
    }
}

// void PrintMatrixTwo(int[,] matrixTwo)
// {
//     for (int i = 0; i < matrixTwo.GetLength(0); i++)
//     {
//     Console.Write("|");
//     for (int j = 0; j < matrixTwo.GetLength(1); j++)
//     {
//         Console.Write($"{matrixTwo[i, j], 5} ");
//     }
//     Console.WriteLine("|");
//     }
// }

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
    }
    return matrix3;
}

 
int[,] matrix1 = CreateMatrixRndInt(2, 2, 1, 5);
int[,] matrix2 = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] matrix3 = MultMatrix(matrix1, matrix2);
Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(matrix3);

