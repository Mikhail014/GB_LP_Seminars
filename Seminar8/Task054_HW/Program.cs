// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] GetMatrixDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {    
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j - 1];
                    matrix[i, j - 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
System.Console.WriteLine("\nМатрица:");
PrintMatrix(matrix);

int[,] newMatrix = GetMatrixDescending(matrix);
System.Console.WriteLine("\nМатрица. Сортировка по убыванию:");
PrintMatrix(newMatrix);