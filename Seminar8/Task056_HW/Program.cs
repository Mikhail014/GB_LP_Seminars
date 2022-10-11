// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetRowSmallestSumOfElements(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int[] sumsArrays = new int[rows];
    int indexMinSum = 0;
    int minSum = default;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            sumsArrays[i] += matrix[i, j];
        }
        if (i == 0) minSum = sumsArrays[0];
        else if (sumsArrays[i] < minSum) 
        {
            indexMinSum = i;
            minSum = sumsArrays[i];
        }
        System.Console.WriteLine($"\nСумма строки {i + 1}: {sumsArrays[i]}");
    }

    return indexMinSum + 1;
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
int res = GetRowSmallestSumOfElements(matrix);

if (rows == columns) System.Console.WriteLine("Задайте прямоугольную матрицу!");
else{
    System.Console.WriteLine("\nМатрица:");
    PrintMatrix(matrix);
    System.Console.WriteLine($"Строка с минимальной суммой элементов: {res}");
}