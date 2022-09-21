Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdNumber(int num)
{
    num = Math.Abs(num);
    if (num < 100) return -1;
    while (num >= 1000)
    {
        num /= 10;
    }
    return num % 10;
}

Console.WriteLine(ThirdNumber(number) == -1 ? "Третьей цифры нет" : $"Третье число: {ThirdNumber(number)}");