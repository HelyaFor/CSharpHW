/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53    
*/

Console.WriteLine("Пожалуйста, введите значение координаты x1: ");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите значение координаты x2: ");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите значение координаты y1: ");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите значение координаты y2: ");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите значение координаты z1: ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите значение координаты z2: ");
int bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((bx-ax),2)+ Math.Pow((by-ay),2) + Math.Pow((bz-az),2));

Console.WriteLine($"Расстояние между точками равно: {result}");