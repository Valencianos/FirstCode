// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 2;
int res = A;

while (count <= B)
{
    res *= A;
    count++;
}
Console.WriteLine(res);

int Pow(num1, num2)
{
    int count = 2;
    int res = num1;

    while (count <= num2)
    {
        res *= num1;
        count++;
    }
    Console.WriteLine(res);
}

int num = Pow(3, 9);
Console.WriteLine(num);