//Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, 
//в которой находится эта точка.
Console.WriteLine("Введите  координату по Х");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  координату по Y");
int Y = Convert.ToInt32(Console.ReadLine());
if (X>0 && Y>0)
{
    Console.WriteLine("Точка в первой координатной четверти");
}
else if (X<0 && Y>0)
{
     Console.WriteLine("Точка во второй координатной четверти");
}
else if (X<0 && Y<0)
{
     Console.WriteLine("Точка в третьей координатной четверти");
}
else if (X>0 && Y<0)
{
     Console.WriteLine("Точка в четвертой координатной четверти");
}
else
{
    Console.WriteLine("По нулям...");
}