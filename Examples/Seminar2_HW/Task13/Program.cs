// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
{
    Console.WriteLine("There is no 3rd digit");
}
else
{
    while (a >= 1000)
    {
        a /= 10;
    }
    int result = a % 10;
    Console.WriteLine(result);
}