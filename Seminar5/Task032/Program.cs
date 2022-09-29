int[] GetInversionArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

int[] arrayNums = GetInversionArray(new int[]{-4, -8, 4, 8});

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

PrintArray($"Инверсия массива: {arrayNums}");