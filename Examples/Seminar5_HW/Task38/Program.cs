// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// создаем массив из 10 элементов и заполняем
// его случайными числами от 100 до 999 и
// выводим его на консоль 
float[] array = new float[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

// Находим максимальное число в массиве
// и выводим его на консоль
float max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"Max Number is: {max}");

// Находим минимальное число в массиве
// и выводим его на консоль
float min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}
Console.WriteLine($"Min Number is: {min}");

// выводим на консоль разность между
// максимальным и минимальным числом
// в массиве
Console.WriteLine($"Difference between Max and Min: {max - min}");