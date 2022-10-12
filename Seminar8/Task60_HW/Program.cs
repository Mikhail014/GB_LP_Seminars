// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Размер двумерного массива");

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Глубина: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] Create3DMatrixRandInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] uniqueNums = new int[rows * columns * depth];
    int ind = default;
    Random r = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int randNum = r.Next(10, 40);
                while (Array.IndexOf(uniqueNums, randNum) != -1) 
                {
                    randNum = r.Next(10, 40);
                }
                uniqueNums[ind++] = randNum;
                matrix[i, j, k] = randNum;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($" {matrix[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine("]");
    }
}

int[,,] matrix3D = Create3DMatrixRandInt(rows, columns, depth);
System.Console.WriteLine("\nТрехмерная матрица:");
Print3DMatrix(matrix3D);