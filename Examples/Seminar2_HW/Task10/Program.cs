// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a < 99) || (a > 1000))
{
    Console.WriteLine("Incorrect number. Please, enter again");
}
else
{
    int b = a / 10;
    int c = b % 10;
    Console.WriteLine(c);
}