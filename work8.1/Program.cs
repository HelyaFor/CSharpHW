/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

        Console.WriteLine("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int[,] array = new int[rows, columns];
        
        void CreatArray (int[,] array)
        {  
            for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(1, 10);
                    }
                }
                
        }
        CreatArray(array);
        Console.WriteLine("Первоначальный массив: ");

        void PrintArray(int[,] array)
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            Console.Write(array[i, j] +" ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
        PrintArray(array);
        Console.WriteLine("Отсротированный массив: ");
            
            void SortArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int h = 0; h < array.GetLength(1) - 1; h++)
                            {
                                if (array[i, h] < array[i, h + 1])
                                {
                                    int temp = array[i, h];
                                    array[i, h] = array[i, h + 1];
                                    array[i, h + 1] = temp;
                                }   
                            }
                    } 
                }
            }
         SortArray(array);
         PrintArray(array);

                    