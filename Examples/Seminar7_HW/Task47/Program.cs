// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int NumberEnter(string message)
{
    Console.Write(message);
    var input = Console.ReadLine();
    int result = Convert.ToInt32(input);
    return result;
}

double[,] CreateArray(int rows, int columns)
{
    double[,] massive = new double[rows, columns];
    return massive;
}

void PrintArray(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j],6} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = Math.Round(new Random().Next(-99,100) * 0.1, 1);
        }
    }
    return collection;
}

double[,] arr = CreateArray(NumberEnter("Enter number of rows: "), NumberEnter("Enter number of columns: "));
PrintArray(arr);
FillArray(arr);
Console.WriteLine();
PrintArray(arr);

