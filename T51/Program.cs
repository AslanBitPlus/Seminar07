// Задача 46. Задайте двумерный массив. Найдите
// сумму элементов, находящихся на главной диагонали
// с индексами (0, 0); (1, 1) и т.л..


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
// Находим сумму элементов главной диагонали.
int SumDiagonalMatrix(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i ++)
    {
        result += matrix[i, i];
    }
    return result;
}

// =======================

int[,] rndMatrix = CreateMatrixRndInt(3, 4, -9, 9);
PrintIntMatrix(rndMatrix);
Console.WriteLine();
int sumDiagonal = SumDiagonalMatrix(rndMatrix);
Console.WriteLine($"Сумма элементов главной диагонали равен: {sumDiagonal}");