// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение Ax: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Ay: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Az: ");
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Bx: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение By: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Bz: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)), 2);
Console.WriteLine($"Расстояние: {d}");