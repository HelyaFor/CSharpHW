﻿/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[7];


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.WriteLine(array[i] + " ");
}

int num = 0;
int amount = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        {
         num = array [i]; 
         amount = amount + 1;
        }
}
Console.WriteLine($"Количество чётных чисел в указанном массиве: {amount}");
