// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

Console.WriteLine("Задай позиции элемента:");

Console.Write("Номер строки: ");
int indRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int indColumn = Convert.ToInt32(Console.ReadLine());

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

string GetElementFromMatrix(int[,] matrix, int row, int col)
{
    row--;
    col--;
    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
        return $"Элемент в заданной позиции: {matrix[row, col]}";
    else
        return "Элемента в заданной позиции нет";        
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
System.Console.WriteLine("\nМатрица");
PrintMatrix(matrix);

string res = GetElementFromMatrix(matrix, indRow, indColumn);
Console.WriteLine(res);