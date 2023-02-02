// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter Ax: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Ay: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Az: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Bx: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter By: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Bz: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double length = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);

Console.WriteLine(length);