//Задача 20
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты точки А по Х");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по Y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по Z");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по Х");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по Y");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по Z");
double zB = Convert.ToDouble (Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xB-xA,2)+Math.Pow(yB-yA,2)+Math.Pow(zB-zA,2));
Console.WriteLine($"{res:f2}");