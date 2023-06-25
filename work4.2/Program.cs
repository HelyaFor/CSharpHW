/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Пожалуйста, введите число: ");
int num = int.Parse(Console.ReadLine());
int sum  = 0;

while (num != 0)
{
   int i = num % 10;
   sum = sum + i;
   num = num / 10;
}
Console.WriteLine("Сумма цифр данного числа ровняется: " + sum);