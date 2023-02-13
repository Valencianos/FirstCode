// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter number: ");
string a = Convert.ToString(Console.ReadLine());

string[] nums = a.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
int[] n = nums.Select(Int32.Parse).ToArray();

int count = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0) count += 1;
}
Console.Write($"->{count} ");
