Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRandomNums(int size, int min, int max)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int FindNumberOfElements(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    return count;
}

int[] arr = CreateArrayRandomNums(size, min, max);
int res = FindNumberOfElements(arr);

Console.WriteLine("Массив:");
PrintArray(arr);

Console.WriteLine($"Количество чисел: {res}");