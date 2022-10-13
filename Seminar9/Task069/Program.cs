Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int RaiseNumberToPower(int num, int degree)
{
    if (degree == 0) return 1;
    return num * RaiseNumberToPower(num, degree - 1);
}

int res = RaiseNumberToPower(n1, n2);
System.Console.WriteLine($"Число {n1} в степени {n2} = {res}");