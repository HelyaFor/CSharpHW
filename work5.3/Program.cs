/*Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] array = new double[5] {3.22, 4.2, 1.15, 77.15, 65.2};

for (int i = 0; i < array.Length; i++)
{
    //array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 5), 2);array[i] = Math.Round(new Random().NextDouble() * new Random().Next(0, 10), 2);
    Console.WriteLine(array[i] + " ");
}

double min = array[0];

for (int i = 0; i < array.Length; i++)
{
     if( min > array[i])
        {
            min = array[i];
        }
}

Console.WriteLine($"Минимальный элемент массива: {min}");

double max = array [0];

for (int i = 0; i < array.Length; i++)
{   if (max < array[i])
        {
            max = array[i];
        }
}

Console.WriteLine($"Максимальный элемент массива: {max}");

double D = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {D}");
