// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] christmas)
{
    int length = christmas.Length;
    int index = 0;
    while (index < length)
    {
        christmas[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int[] newyear)
{
    int count = newyear.Length;
    int position = 0;
    while (position < count)
    {
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
Console.Write($"array: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");
