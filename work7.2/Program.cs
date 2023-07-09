/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
        Console.WriteLine("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int[,] array = new int[5, 6];
        {
        {  
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(1, 10);
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
            if (rows < array.GetLength(0) && columns < array.GetLength(1)) 
                {
                    Console.WriteLine($"Элемент найден в массиве: {array[rows, columns]}");
                }
            else 
                {
                    Console.WriteLine($"Указанный элемент отсутствует в массиве");
                }
        }   

        
        
        

       