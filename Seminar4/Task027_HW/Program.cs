// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetSumOfNums(int n)
{
    if (n < 0) n = -n;
    int sum = default;
    while (n != 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

int res = GetSumOfNums(num);

Console.WriteLine($"Сумма цифр в числе {num} равна {res}");