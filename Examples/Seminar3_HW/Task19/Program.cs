// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter 5-digits number: ");
int num = Convert.ToInt32(Console.ReadLine());


if ((num / 10000 == num % 10) && (((num / 1000) % 10) == (num % 100) / 10)) 
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}