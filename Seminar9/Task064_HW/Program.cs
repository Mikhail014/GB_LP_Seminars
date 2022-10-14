Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void GetNaturalNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    GetNaturalNumbers(n - 1);
}

GetNaturalNumbers(num);