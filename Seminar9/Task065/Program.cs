Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

void GetNaturalNumbersFromMinToMax(int n, int m)
{
    if (m > n)
    {
        GetNaturalNumbersFromMinToMax(n, m - 1);
        Console.Write($"{m} ");
    }
    if (m < n)
    {
        Console.Write($"{n} ");
        GetNaturalNumbersFromMinToMax(n - 1, m);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }
}

GetNaturalNumbersFromMinToMax(n, m);