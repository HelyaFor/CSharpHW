/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
наименьшей суммой элементов: 1 строка*/

       Console.WriteLine("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int[,] array = new int[rows, columns];
        
        {  
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(1, 7);
                    }
                }
        }
           for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            Console.WriteLine(" ");
            }
        {   
                
            int temp = 0;
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    int sum = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                if (i == 0 || sum < temp) 
                    {
                        temp = sum;
                        result = i;
                    }
                }
            Console.WriteLine($"Cтрока с наименьшей суммой элементов: {result + 1}");
        }
