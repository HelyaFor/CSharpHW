/*Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Пожалуйста, введите целое число (M): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите целое число (N): ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int amountNum (int m)
{
if (m >= 1 && m <= n)
{
    sum += m;
    amountNum(m + 1);
}
return sum;
}
int result = amountNum(m);
Console.WriteLine("Сумма натуральных чисел: " + result);