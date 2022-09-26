Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberOfDigits(int n)
{
    int count = 0;
    if (count == 0 && n == 0) return 1;
    while (n != 0)
    {
        n /= 10;
        count++;
    }
    return count;
}

System.Console.WriteLine($"Количество цифр в числе {num}: {NumberOfDigits(num)}");