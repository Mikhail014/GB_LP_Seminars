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

int[,] SwapFirstAndLastArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int colls = matrix.GetLength(1);
    int[,] res = new int[rows, colls];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colls; j++)
        {
            if (i == 0) res[0, j] = matrix[rows - 1, j];
            else if (i == rows - 1) res[rows - 1, j] = matrix[0, j];
            else res[i, j] = matrix[i, j];
        }
    }

    return res;
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
System.Console.WriteLine("\nМатрица:");
PrintMatrix(matrix);

int[,] res = SwapFirstAndLastArray(matrix);
System.Console.WriteLine("\nНовая матрица:");
PrintMatrix(res);