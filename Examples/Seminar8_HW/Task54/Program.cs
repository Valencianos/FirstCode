// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            collection[i, j] = new Random().Next(1, 10);
        }
    }
    return collection;
}

int[,] DescendInRows(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            for (int k = j + 1; k < coll.GetLength(1); k++)   
            {
                if(coll[i,j] < coll[i,k])
                {
                    int temporary = coll[i,j];
                    coll[i,j] = coll[i,k];
                    coll[i,k] = temporary;
                }
            }
        }
    }
    return coll;
}


int[,] arr = CreateArray(NumberEnter("Enter rows: "), NumberEnter("Enter columns: "));
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
DescendInRows(arr);
PrintArray(arr);