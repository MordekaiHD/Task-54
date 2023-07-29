// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Organize2DMassive(int[,] massive)
{
    int temp = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1) - 1; k++)
            {
                if(massive[i, k] < massive[i, k + 1])
                {
                    temp = massive[i, k + 1];
                    massive[i, k + 1] = massive[i, k];
                    massive[i, k] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("В итоге получается вот такой массив:");
    Print2DMassive(massive);
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassiv(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}
int[,] massive = Create2DMassiv(5, 5, 1, 10);
Console.WriteLine("Например, задан массив: ");
Print2DMassive(massive);
Organize2DMassive(massive);
