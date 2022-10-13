// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Console.WriteLine("Размер двумерного массива");

// Console.Write("Количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == 0) matrix[i, j] = count++;
            else if (i > 0 && j == columns - 1) matrix[i, j] = count++;
            else if (i == rows - 1 && j > 0) matrix[i, i - j] = count++;
            // System.Console.WriteLine($"{matrix[i, j]} - {i} , {j}");
        }
        // PrintMatrix(matrix);
        System.Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write("0");
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 4);
System.Console.WriteLine("\nМатрица:");
PrintMatrix(matrix);