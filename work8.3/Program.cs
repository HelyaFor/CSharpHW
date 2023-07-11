/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
        Console.WriteLine("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int[,] matrix = new int[rows, columns];
        
        {  
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(1, 10);
                    }
                }
        }
           for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            Console.WriteLine(" ");
            }

            Console.WriteLine("Введите количество строк: ");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов: ");
            int columns1 = Convert.ToInt32(Console.ReadLine());
            Random random1 = new Random();
            int[,] matrix2 = new int[rows1, columns1];
           
            {  
                for (int i = 0; i < matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix2.GetLength(1); j++)
                        {
                            matrix2[i, j] = random.Next(1, 10);
                        }
                    }
            }
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                Console.WriteLine(" ");
                }
               
               int[,] sumMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

                for (int a = 0; a < matrix.GetLength(0); a++)
                {
                    for (int b = 0; b < matrix.GetLength(1); b++)
                    {
                        sumMatrix[a, b] = matrix[a, b] * matrix2[a, b];
                        Console.WriteLine($"Произведение двух матриц: { sumMatrix [a, b]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(); 
