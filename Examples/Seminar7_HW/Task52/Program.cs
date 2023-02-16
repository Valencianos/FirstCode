// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{massive[i, j],3} ");
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
            collection[i,j] = new Random().Next(1,10);
        }
    }
    return collection;
}

double[] ColumnAverage(double[,] coll)
{
    double[] array = new double[coll.GetLength(1)];
    for (int j = 0; j < coll.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < coll.GetLength(0); i++)
        {
            sum += coll[i,j];
        }
        array[j] = Math.Round(sum / coll.GetLength(0),1);
    }
    return array;
}


double[,] arr = CreateArray(NumberEnter("Enter rows: "), NumberEnter("Enter columns: "));
FillArray(arr);
PrintArray(arr);

Console.WriteLine($"Среднее арифметическое по столбцам: {string.Join(", ", ColumnAverage(arr))}");