Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string GetCoords(int q)
{
    if (q == 1) return "X меньше нуля, Y больше нуля";
    if (q == 2) return "X больше нуля, Y больше нуля";
    if (q == 3) return "X меньше нуля, Y меньше нуля";
    if (q == 4) return "X больше нуля, Y меньше нуля";
    return "Введите число от 1 до 4 включительно!!!";
}

string result = GetCoords(quarter);

Console.WriteLine(quarter < 2 || quarter > 4 ? result : $"Диапазон возможных координат: {result}");