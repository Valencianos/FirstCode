// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
int res = 0;
while (num > 0)
{
    res = res + (num % 10);
    num = num / 10;
    i++;
}
Console.WriteLine(res);
