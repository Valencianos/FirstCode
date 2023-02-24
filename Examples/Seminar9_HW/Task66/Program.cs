// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Please, enter M: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter N: ");
int max = Convert.ToInt32(Console.ReadLine());

int GetSum(int min, int max)
{
    if(min == max) return max;
    else
    {
        return min + GetSum (min + 1, max);
    }
}

Console.Write(GetSum(min, max));