﻿/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите несколько чисел (через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int num = 0;

for (int i = 0; i < array.Length ; i++)
{
    if (array[i] > 0)
    {
        num++;
    }
}
 
Console.WriteLine($"Количество чисел больше нуля: {num}");