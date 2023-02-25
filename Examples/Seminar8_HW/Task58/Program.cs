// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int NumberEnter(string message)
{
    Console.Write(message);
    var input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] massive = new int[rows, columns];
    return massive;
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 6);
        }
    }
    return collection;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] matrixA = CreateArray(NumberEnter("Enter number of rows matrix A: "), NumberEnter("Enter number of columns matrix A: "));
int[,] matrixB = CreateArray(NumberEnter("Enter number of rows matrix B: "), NumberEnter("Enter number of columns matrix B: "));
FillArray(matrixA);
FillArray(matrixB);
PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
PrintArray(MatrixMultiplication(matrixA, matrixB));