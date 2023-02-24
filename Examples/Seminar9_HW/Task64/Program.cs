// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter N: ");
int num = Convert.ToInt32(Console.ReadLine());

int DecreaseOrder(int num)
{
    if (num == 0) return 0;
    else 
    {
        Console.Write($"{num} ");
        return DecreaseOrder (num - 1);
    }
}

DecreaseOrder(num);