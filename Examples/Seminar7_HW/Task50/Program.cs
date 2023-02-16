// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] arr = CreateArray(NumberEnter("Enter number of rows: "), NumberEnter("Enter number of columns: "));
FillArray(arr);
PrintArray(arr);
int find = (NumberEnter("Enter number for look up: "));
string n = "-> number not found in array";

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(arr[i,j] == find) n = "-> number found in array";
    }
}
Console.WriteLine($"{find} {n}");
