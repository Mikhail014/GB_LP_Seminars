// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRandomDoubleNums(int size, int min, int max)
{
    double[] array = new double[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        double value = r.NextDouble() * (max - min) + min;
        array[i] = Math.Round(value, 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double GetDiffBetweenMaxAndMinArrayElem(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return Math.Round(max - min, 1, MidpointRounding.ToZero);
}

double[] arr = CreateArrayRandomDoubleNums(size, min, max);
double res = GetDiffBetweenMaxAndMinArrayElem(arr);

Console.Write("Массив: ");
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {res}");