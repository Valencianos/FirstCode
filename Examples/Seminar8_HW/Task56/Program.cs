// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[,] array = CreateArray(NumberEnter("Enter number of rows: "), NumberEnter("Enter number of columns: "));
FillArray(array);
PrintArray(array);

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLineElements(array, i);
  if (sumLine > temp)
  {
    sumLine = temp;
    minSumLine = i;
  }
}
Console.WriteLine($"Row with minimum sum: {minSumLine+1}");
