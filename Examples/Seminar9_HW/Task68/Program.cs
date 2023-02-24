// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Please, enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetAccerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAccerman(m - 1, 1);
    else return GetAccerman(m - 1, GetAccerman(m, n - 1));
}

Console.Write(GetAccerman(m, n));