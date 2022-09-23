Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetTableQuad(int n)
{
    if (n <= 0) return "Введите положительное число!!!";
    int i = 1;
    string res = "\nТаблица квадратов:\n";
    while (i <= n)
    {
        res += $"{i,3} {Math.Pow(i, 2).ToString(), 3}\n";
        i++;
    }
    return res;
}

Console.WriteLine(GetTableQuad(num));