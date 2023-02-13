// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pow(int num1, int num2)
{
    int count = 2;
    int res = num1;

    while (count <= num2)
    {
        res *= num1;
        count++;
    }
    return res;
}

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int num = Pow(A, B);
Console.WriteLine(num);