/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Пожалуйста, введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите степень числа: ");
int n = int.Parse(Console.ReadLine());
int a = num;

for (int i = 1; i < n; i++)
{
   a = a * num;
}
Console.WriteLine($"Степень числа: {a}");