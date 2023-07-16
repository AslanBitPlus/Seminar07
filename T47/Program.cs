// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Создание двумерного массива заполненного случайными вещественными числами
double[,] CreateRndMatrixDouble(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            double num = rnd.NextDouble() * (max - min) * min;
            array[i, j] = Math.Round(num, 1);
        }
    }
    return array;
}
// Печать двумерного массива
void PrintIntMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j], 7} ");
        }
        Console.WriteLine("|");
    }
}

// =======================
double[,] rndMatrix = CreateRndMatrixDouble(7, 4, 1, 12);
PrintIntMatrix(rndMatrix);
