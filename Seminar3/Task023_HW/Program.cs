// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetTableCube(int n)
{
    if (n <= 0) return "Введите положительное число!!!";
    int i = 1;
    string res = "\nТаблица квадратов:\n";
    while (i <= n)
    {
        res += $"{i} {Math.Pow(i, 3).ToString(), 5}\n";
        i++;
    }
    return res;
}

Console.WriteLine(GetTableCube(num));