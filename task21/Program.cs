//Задача 21: Напишите программу, 
//которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
Console.WriteLine($"{res:f2}");
