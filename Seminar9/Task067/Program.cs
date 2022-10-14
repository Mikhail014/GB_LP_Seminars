Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumOfNums(int n)
{
    if (n == 0) return 0;
    return GetSumOfNums(n / 10) + n % 10;
}

int res = GetSumOfNums(num);

System.Console.WriteLine($"Сумма цифр числа {num}: {res}");