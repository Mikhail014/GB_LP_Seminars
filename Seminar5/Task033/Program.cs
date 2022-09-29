Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

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

bool IsElementInArray(int n, int[] arr)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n) 
        {
            result = true;
            break;
        }
    }
    return result;
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

int[] arr = CreateArrayRandomNums(size, min, max);
bool res = IsElementInArray(num, arr);

Console.WriteLine("Массив:");
PrintArray(arr);

if (res) Console.WriteLine($"Число {num} присуствует в массиве!");
else Console.WriteLine($"Число {num} не присуствует в массиве!");