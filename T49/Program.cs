// Задача 46. Задайте двумерный массив. Найдите
// элементы, у которыъ оба индекса четные, и замените
// эти элементы на их квадраты.


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
// Меняем элементы, у которыъ оба индекса четные на их квадраты.
void ReplaceMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

// =======================

int[,] rndMatrix = CreateMatrixRndInt(3, 4, -9, 9);
PrintIntMatrix(rndMatrix);
Console.WriteLine();
ReplaceMatrix(rndMatrix);
PrintIntMatrix(rndMatrix);