// Задача 48. Задайте двумерный массив размером m x n, 
// Каждый элемент в массиве наъодится по формуле: А[m, n] = m + n
// Выведите полученный массив на экран

// Создание двумерного массива заполненного по формуле: А[m, n] = m + n
int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        for (int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = i + j;
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

int[,] rndMatrix = CreateMatrixRndInt(9, 9);
PrintIntMatrix(rndMatrix);