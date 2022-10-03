Console.OutputEncoding = System.Text.Encoding.UTF8;

// Console.Write("Количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Минимальное число: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Максимальное число: ");
// int max = Convert.ToInt32(Console.ReadLine());

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

void ReverseArray(int[] arr)
{
    int i1 = 0;
    int i2 = arr.Length - 1;

    while (i1 < i2)
    {
        int temp = arr[i1];
        arr[i1] = arr[i2];
        arr[i2] = temp;
        i1++;
        i2--;
    }


}



void ReverseArray2(int[] arr)
{
    
    int i2 = arr.Length - 1;

    for (int i = 0; i < i2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[i2];
        arr[i2] = temp;
        i2--;
    }


}


int[] arr = CreateArrayRandomNums(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
Array.Reverse(arr);
PrintArray(arr);
ReverseArray2(arr);
PrintArray(arr);