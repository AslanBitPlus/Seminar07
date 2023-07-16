// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Создание двумерного массива заполненного случайными числами
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

int[,] rndMatrix = CreateMatrixRndInt(3, 4);
PrintIntMatrix(rndMatrix);

Console.Write("Введите индекс строки: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine());


if (rowsNumber >= 0 
    && rowsNumber < rndMatrix.GetLength(0)
    && columnsNumber >= 0 
    && columnsNumber < rndMatrix.GetLength(1) ) 
    {
        Console.WriteLine($"Элемент с индексом [{rowsNumber}, {columnsNumber}] = {rndMatrix[rowsNumber, columnsNumber]} ");
    }
else Console.WriteLine($"Такой позиции [{rowsNumber}, {columnsNumber}] в массиве НЕТ!");
