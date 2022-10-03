Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Максимальное число: ");
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

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

int[] arr = CreateArrayRandomNums(size, min, max);
int[] copyArr = CopyArray(arr);

Console.Write("Оригинальный массив: ");
PrintArray(arr);

Console.Write("Копия массива: ");
PrintArray(copyArr);