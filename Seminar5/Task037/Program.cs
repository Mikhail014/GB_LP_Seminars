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

string GetMulPairsOfNums(int[] arr)
{
    string res = default;
    int len = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1; 
    for (int i = 0; i < len; i++)
    {
        if (i == arr.Length - 1 - i) res += $"{arr[i]} ";
        else res += $"{arr[i] * arr[arr.Length - 1 - i]} ";
    }
    return res;
}

int[] arr = CreateArrayRandomNums(size, min, max);
Console.WriteLine("Массив:");
PrintArray(arr);
string res = GetMulPairsOfNums(arr);

Console.WriteLine("Произведение пар чисел: ");
Console.Write(res);