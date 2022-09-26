Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumOfNums(int n)
{
    int sum = default;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

System.Console.WriteLine($"Сумма чисел от 1 до {num} равна {SumOfNums(num)}");