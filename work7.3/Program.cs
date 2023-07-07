/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[4, 4];

 for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 5);
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine();
        }
 for (int i = 0; i < array.GetLength(1); i++)
        {
        double sum = 0;
        double result = 0;
            for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum += array[j, i];
                }
            result = sum / array.GetLength(0);
            Console.Write($"Cреднее арифметическое элементов в столбце: {result}; ");
        }
        
