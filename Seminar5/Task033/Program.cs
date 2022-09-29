Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsElementInArray(int n, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == n) return true;
    }
    return false;
}

bool res = IsElementInArray(num, new int[]{2, 5, 3, 2});

if (res) Console.WriteLine($"Число {num} присуствует в массиве!");
else Console.WriteLine($"Число {num} не присуствует в массиве!");