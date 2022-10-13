Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumOfNums(int n)
{
    int sum = default;
    while(n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int res = GetSumOfNums(num);

System.Console.WriteLine(res);