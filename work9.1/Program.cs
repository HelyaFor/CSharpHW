﻿/*Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Пожалуйста, введите целое число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    int natN(int n)
    {
        Console.WriteLine(n);
        if (n == 1) return 1;
        return natN (n - 1);
    }
    natN(n);
}