// Задача 46. Задайте двумерный массив размером m x n, 
// заполненный случайными числами.

// m = 3, n = 4

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Создание двумерного массива заполненного случайными числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
// Печать двумерного массива
void PrintIntMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

// =======================

int[,] rndMatrix = CreateMatrixRndInt(3, 4, -9, 9);
PrintIntMatrix(rndMatrix);