Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
    if (n == 0) return 1;
    if (n < 0) return -1;
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}

int res = Factorial(num);

System.Console.WriteLine(res != -1 ? $"Факториал числа {num} равен {res}" : "Ошибка! Введенное число должно быть больше, либо равно нулю!");