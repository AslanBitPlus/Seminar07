// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] AverageColumnsMatrix(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j ++)
    {
        for (int i = 0; i < array.GetLength(0); i ++)
        {
            arr[j] += array[i, j];
        }
        arr[j] /= array.GetLength(0);
        arr[j] = Math.Round(arr[j], 1);
    }
    return arr;
}
// =======================
void PrintDoubleArray(double[] array, string sep = " ")
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]}{sep} ");
    }
}
// =======================


int[,] rndMatrix = CreateMatrixRndInt(3, 4, 1, 8);
PrintIntMatrix(rndMatrix);

double[] sumArray = AverageColumnsMatrix(rndMatrix);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintDoubleArray(sumArray);



