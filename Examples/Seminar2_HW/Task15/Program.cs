// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a number indicating the day of the week (from 1 to 7): ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a == 6) || (a == 7))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}