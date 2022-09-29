Console.OutputEncoding = System.Text.Encoding.UTF8;

// Console.Write("Количество элементов в массиве: ");
// int length = Convert.ToInt32(Console.ReadLine());

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

int[] arr = CreateArrayRandomNums(12, -9, 9);
PrintArray(arr);


int[] GetSumPositiveAndNegativeNums(int[] arr)
{
    int sumPositive = default;
    int sumNegative = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[]{sumPositive, sumNegative};
}

int GetSumPositiveNums(int[] arr)
{
    int sumPositive = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive += arr[i];
    }
    return sumPositive;
}



int GetSumNegativeNums(int[] arr)
{
    int sumNegative = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative += arr[i];
    }
    return sumNegative;
}


int sumPositiveNums = GetSumPositiveNums(arr);
int sumNegativeNums = GetSumNegativeNums(arr);


Console.WriteLine($"Сумма положительных чисел в массиве: {sumPositiveNums}");
Console.WriteLine($"Сумма отрицательных чисел в массиве: {sumNegativeNums}");