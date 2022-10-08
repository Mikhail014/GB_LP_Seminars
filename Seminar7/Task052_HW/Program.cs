// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Размер двумерного массива");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRandInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random r = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = r.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j]} |");
            else Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

double[] GetAverageEachColumn(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    double[] res = new double[col];
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            res[i] += matrix[j, i];
        }
        res[i] /= row;
    }
    return res;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], 1, MidpointRounding.ToZero);
        if (i < arr.Length - 1) Console.Write($"{num} | ");
        else Console.Write($"{num}");
    }
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
System.Console.WriteLine("\nМатрица:");
PrintMatrix(matrix);

double[] arr = GetAverageEachColumn(matrix);
System.Console.Write("\nСреднее арифметическое каждого столбца: ");
PrintArray(arr);