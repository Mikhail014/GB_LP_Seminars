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

int[,] DeleteRowAndColumnWithMinValue(int[,] matrix)
{

    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    int delRow = default;
    int delCol = default;

    int min = matrix[0, 0];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i, j] < min)
            {
                delRow = i;
                delCol = j;
                min = matrix[i, j];
            }

        }
    }

    int rowNewMatrix = 0;
    int colNewMatrix = 0;

    int[,] newMatrix = new int[rows - 1, cols - 1];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (delRow != i && delCol != j)
            {
                newMatrix[rowNewMatrix, colNewMatrix] = matrix[i, j];
                if (colNewMatrix < cols - 2) 
                {
                    colNewMatrix++;
                }
                else
                {
                    colNewMatrix = 0;
                    rowNewMatrix++;
                }
                
            }

        }
    }

    return newMatrix;
}

int[,] matrix = CreateMatrixRandInt(rows, columns, min, max);
System.Console.WriteLine("\nМатрица:");
PrintMatrix(matrix);

int[,] res = DeleteRowAndColumnWithMinValue(matrix);
System.Console.WriteLine("\nНовая матрица:");
PrintMatrix(res);